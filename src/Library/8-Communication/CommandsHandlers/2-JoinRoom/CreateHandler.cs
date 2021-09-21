namespace Library
{
    public class CreateHandler : AbstractHandler
    {
        public CreateHandler()
        :base(new JoinHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if (command.Equals(translate.Translate("create",player.Language)) && player.Phase is WaitingForJoinPhase)
            {
                player.SendMessage(message[0] + " " + Rooms.Instance.AddSession(player));
                player.NextState();
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}