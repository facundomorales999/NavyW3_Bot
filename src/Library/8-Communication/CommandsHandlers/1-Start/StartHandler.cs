namespace Library
{
    public class StartHandler : AbstractHandler
    {
        public StartHandler()
        : base(new CreateHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if (command.Equals(translate.Translate("start", player.Language)) && player.Phase is WaitingForStartPhase)
            {
                player.SendMessage(message[0]);
                player.NextState();
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}