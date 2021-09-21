namespace Library
{
    public class PositioningItemsHandler : AbstractHandler
    {
        private static int _times = 3;
        public static int Times
        {
            get
            {
                return _times;
            }
        }

        public PositioningItemsHandler()
        : base(new ShowItemsHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if (command.StartsWith(translate.Translate("add", player.Language)) && player.Phase is PositioningItemsPhase && command.Split(" ").Length == 3)
            {
                int vesselInt = StringToInt.Convert(1, player.GetListOfVessels().Count, command.Split(" ")[1], player, message[1]) - 1;
                int position = -2;
                if (vesselInt != -2)
                {
                    position = StringToInt.Convert(1, player.GetListOfVessels()[vesselInt].Length(), command.Split(" ")[2], player, message[2]) - 1;
                }

                if (vesselInt != -2 && position != -2)
                {
                    try
                    {
                        player.AddItem(position, ItemContainer.Instance.GetItem(player).Item2, player.GetListOfVessels()[vesselInt]);
                        ItemContainer.Instance.NewItem(player);
                        player.SendMessage(message[3]);
                        if (ItemContainer.Instance.GetItem(player).Item1 <= PositioningItemsHandler._times)
                        {
                            AbstractIItemsToString itemsToString = new HeadIItemsToString();
                            player.SendMessage(message[4] + " " + itemsToString.ToString(ItemContainer.Instance.GetItem(player).Item2, player.Language));
                        }
                        else
                        {
                            player.NextState();
                        }
                    }
                    catch (ItemAddException e)
                    {
                        AbstractItemValidatorsExceptionsToString exceptionToString = new HeadItemValidatorsExceptionsToString();
                        player.SendMessage(exceptionToString.ToString(e, player.Language));
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