namespace Library
{
    public abstract class AbstractRoomStateManager : AbstractHostManager
    {
        private bool _started;
        protected AbstractRoomStateManager(AbstractPlayer host, int id)
        :base(host, id)
        {
        }
        protected void Start()
        {
            this._started = true;
        }
        public bool IsStarted()
        {
            return this._started;
        }
    }
}