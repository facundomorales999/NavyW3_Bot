namespace Library
{
    public class ClientTelegramPrinter : IPrinter
    {
        public void Print(AbstractPlayerIdManager receptor, string toPrint)
        {
            TelegramBot client = TelegramBot.Instance;
            client.Client.SendTextMessageAsync(
                chatId: receptor.Id,
                text: toPrint.ToString()
            );
        }
    }
}