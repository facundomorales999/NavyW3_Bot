namespace Library
{
    public class HeadCommandHandler : AbstractHandler
    {
        public HeadCommandHandler()
        :base(new StartHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            this.SendNext(command, player);
        }
    }
}