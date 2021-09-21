namespace Library
{
    public class AbstractCommunicationManager : AbstractPlayerIdManager
    {
        private IPrinter _clientP;
        public AbstractCommunicationManager(long id, IPrinter clientP)
        :base(id)
        {
            this._clientP = clientP;
        }
        public void SendMessage(string message)
        {
            this._clientP.Print(this, message);
        }
    }
}