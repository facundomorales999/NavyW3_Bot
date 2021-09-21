namespace Library
{
    public class StartGameHandler : AbstractHandler
    {
        public StartGameHandler()
        : base(new NextVesselHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if (command.Equals(translate.Translate("start",player.Language)) && player.Phase is WaitingForStartGamePhase)
            {

                try
                {
                    Rooms.Instance.Start(player);
                    Rooms.Instance.SendAllByHost(message[0], player);
                }
                catch (NoHostException)
                {
                    player.SendMessage(message[1]);
                }
                catch(NoSinglePlayerException)
                {
                    player.SendMessage(message[2]);
                }
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}