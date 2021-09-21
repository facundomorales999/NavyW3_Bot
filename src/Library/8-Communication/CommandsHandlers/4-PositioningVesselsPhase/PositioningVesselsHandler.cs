namespace Library
{
    public class PositioningVesselsHandler : AbstractHandler
    {
        public PositioningVesselsHandler()
        : base(new RandomAddVesselsHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if (command.StartsWith(translate.Translate("add", player.Language) + " ") && player.Phase is PositioningVesselsPhase && command.Split(" ").Length == 4)
            {
                int x = StringToInt.Convert(1, player.XLength(), command.Split(" ")[1], player, message[1]) - 1;
                int y = StringToInt.Convert(1, player.YLength(), command.Split(" ")[2], player, message[2]) - 1;
                int ori = StringToInt.Convert(0, 1, command.Split(" ")[3], player, message[3]);

                if (x != -2 && y!= -2 && ori != -1)
                {
                    AbstractNextVessel nextVessel = new HeadNextVessel();
                    player.AddVessel(x, y, nextVessel.NextVessel(player.GetListOfVessels()), ori == 1);
                    player.SendMessage(player.ToEmojiTable());

                    if (nextVessel.NextVessel(player.GetListOfVessels()) == null)
                    {
                        player.NextState();
                    }
                }
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}