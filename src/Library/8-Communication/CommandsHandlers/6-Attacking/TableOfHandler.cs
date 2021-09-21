namespace Library
{
    public class ShowEnemiesHandler : AbstractHandler
    {
        public ShowEnemiesHandler()
        : base(new ShowMyTableHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            if(command.StartsWith(translate.Translate("tableof", player.Language) + " ") && player.Phase is AttackPhase && Rooms.Instance.IsPlaying(player) && command.Split(" ").Length == 2)
            {
                if (Rooms.Instance.IsPlayingWith(player, command.Split(" ")[1]))
                {
                    Rooms.Instance.ShowTableOf(player, command.Split(" ")[1]);
                }
                else
                {
                    player.SendMessage(command.Split(" ")[1] + " " + message[8]);
                }
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}
