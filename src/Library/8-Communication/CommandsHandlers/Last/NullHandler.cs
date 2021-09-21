namespace Library
{
    public class NullHandler : AbstractHandler
    {
        public NullHandler()
        :base (null)
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            player.SendMessage("Comando invalido.");
        }
    }
}