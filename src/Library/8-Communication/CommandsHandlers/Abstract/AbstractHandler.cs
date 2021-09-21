namespace Library
{
    public abstract class AbstractHandler
    {
        protected AbstractHandler _nextHandler;
        protected AbstractHandler(AbstractHandler next)
        {
            this._nextHandler = next;
        }
        public abstract void DoCommand(string command, AbstractPlayer player);
        public void SendNext(string command, AbstractPlayer player)
        {
            this._nextHandler.DoCommand(command, player);
        }
    }
}