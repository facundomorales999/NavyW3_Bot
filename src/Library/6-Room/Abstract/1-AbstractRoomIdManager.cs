namespace Library
{
    public abstract class AbstractRoomIdManager
    {
        private int _id;
        protected AbstractRoomIdManager(int id)
        {
            this._id = id;
        }
        public bool IsId(int id)
        {
            return this._id == id;
        }
    }
}