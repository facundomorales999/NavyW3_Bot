namespace Library
{
    public class JoinHandler : AbstractHandler
    {
        public JoinHandler()
        : base(new StartGameHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if (command.StartsWith(translate.Translate("join", player.Language) + " ") && player.Phase is WaitingForJoinPhase && command.Split(" ").Length == 2)
            {
                int roomId = StringToInt.Convert(1, Rooms.Instance.Count(), command.Split(" ")[1], player, message[1]);

                if (roomId != -1)
                {
                    Rooms.Instance.SendAllById(message[2] + " " + player.Name, roomId);
                    Rooms.Instance.AddPlayer(player, roomId);
                    player.SendMessage(message[3]);
                    player.NextState();
                }
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}