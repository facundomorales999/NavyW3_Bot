namespace Library
{
    public abstract class AbstractRoomCommunicationManager : AbstractTablesManager
    {
        public AbstractRoomCommunicationManager(AbstractPlayer host, int id)
        : base(host, id)
        {
        }
        public void SendAll(string message)
        {
            foreach (AbstractPlayer player in this._players)
            {
                player.SendMessage(message);
            }
        }
    }
}