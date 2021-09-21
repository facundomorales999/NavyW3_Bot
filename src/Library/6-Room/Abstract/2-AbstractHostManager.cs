namespace Library
{
    public abstract class AbstractHostManager : AbstractRoomIdManager
    {
        private AbstractPlayer _host;
        protected AbstractHostManager(AbstractPlayer host, int id)
        : base(id)
        {
            this._host = host;
        }
        public bool IsHost(AbstractPlayer player)
        {
            return this._host == player;
        }
    }
}