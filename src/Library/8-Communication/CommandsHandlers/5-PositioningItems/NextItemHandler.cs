namespace Library
{
    public class NextItemHandler : AbstractHandler
    {
        public NextItemHandler()
        : base(new PositioningItemsHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if(command.Equals(translate.Translate("next",player.Language)) && player.Phase is PositioningItemsPhase)
            {
                AbstractIItemsToString itemsToString = new HeadIItemsToString();

                player.SendMessage(message[0] + " " + itemsToString.ToString(ItemContainer.Instance.GetItem(player).Item2,player.Language));
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}
