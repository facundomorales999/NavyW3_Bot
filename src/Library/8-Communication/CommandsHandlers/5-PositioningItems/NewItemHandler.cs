namespace Library
{
    public class NewItemHandler : AbstractHandler
    {
        public NewItemHandler()
        : base(new NextItemHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if(command.Equals(translate.Translate("new",player.Language)) && player.Phase is PositioningItemsPhase)
            {
                if (ItemContainer.Instance.NewItem(player) <= PositioningItemsHandler.Times)
                {
                    AbstractIItemsToString itemsToString = new HeadIItemsToString();
                    player.SendMessage(message[0] + itemsToString.ToString(ItemContainer.Instance.GetItem(player).Item2,player.Language));
                }
                else
                {
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
