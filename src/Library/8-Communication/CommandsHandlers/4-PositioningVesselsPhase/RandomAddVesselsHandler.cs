using System;

namespace Library
{
    public class RandomAddVesselsHandler : AbstractHandler
    {
        public RandomAddVesselsHandler()
        : base(new NewItemHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if (command.Equals(translate.Translate("randomadd", player.Language)) && player.Phase is PositioningVesselsPhase)
            {
                Random random = new Random();
                AbstractNextVessel nextVessel = new HeadNextVessel();

                while(nextVessel.NextVessel(player.GetListOfVessels()) != null)
                {
                    int x = random.Next(1, player.XLength());
                    int y = random.Next(1, player.YLength());
                    int ori = random.Next(0, 2);
                    player.AddVessel(x, y, nextVessel.NextVessel(player.GetListOfVessels()), ori == 1);
                }
                
                player.SendMessage(player.ToEmojiTable());
                player.NextState();
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}