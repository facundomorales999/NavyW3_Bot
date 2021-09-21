namespace Library
{
    public class Player : AbstractPlayer
    {
        public Player(long id, string name, IPrinter clientP)
        :base(name, id, clientP)
        {
        }
    }
}