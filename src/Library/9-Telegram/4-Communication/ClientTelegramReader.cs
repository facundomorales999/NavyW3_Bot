using System;
// Se usa para MessageEventArgs.
using Telegram.Bot.Args;
// Se usa para Message.
using Telegram.Bot.Types;

namespace Library
{
    public class ClientTelegramReader : IReader
    {
        public void StartRead()
        {
            TelegramBot.Instance.Client.OnMessage += SentToChain;
            TelegramBot.Instance.Client.StartReceiving();
        }
        public void StopRead()
        {
            TelegramBot.Instance.Client.StopReceiving();
        }
        private static void SentToChain(object sender, MessageEventArgs messageEventArgs)
        {
            // Cada plataforma tiene su contenedor para evitar repeticiones de id.
            TelegramPlayers players = TelegramPlayers.Instance;

            Message message = messageEventArgs.Message;
            Chat chatInfo = message.Chat;

            string messageText = "";

            try
            {
                messageText = message.Text.ToLower();
            }
            catch (Exception)
            {
                Console.WriteLine($"{chatInfo.FirstName} causo una excepcion.");
            }

            if (messageText != "")
            {

                Console.WriteLine($"{chatInfo.FirstName}: envío {messageText}");

                if (messageText.StartsWith("/"))
                {
                    // Primer punto de la cadena.
                    AbstractHandler start = new HeadCommandHandler();
                    start.DoCommand(messageText.Substring(1, messageText.Length - 1), players.GetPlayer(chatInfo.FirstName, chatInfo.Id));
                }
            }
        }
    }
}