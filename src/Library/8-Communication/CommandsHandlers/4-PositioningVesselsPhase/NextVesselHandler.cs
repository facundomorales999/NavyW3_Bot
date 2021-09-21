namespace Library
{
    public class NextVesselHandler : AbstractHandler
    {
        public NextVesselHandler()
        : base(new PositioningVesselsHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if (command.Equals(translate.Translate("next", player.Language)) && player.Phase is PositioningVesselsPhase)
            {
                AbstractNextVessel nextVessel = new HeadNextVessel();
                AbstractVesselsToString toString = new HeadVesselsToString();
                player.SendMessage(message[0] + " " + toString.ToString(nextVessel.NextVessel(player.GetListOfVessels()), player.Language));
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}