namespace Library
{
    public class ShowMyTableHandler : AbstractHandler
    {
        // EmoticTable
        public ShowMyTableHandler()
        : base(new NullHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);
   
            if(command == translate.Translate("mytable", player.Language) && player.Phase is AttackPhase)
            {
                player.SendMessage(player.ToEmojiTable());
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}