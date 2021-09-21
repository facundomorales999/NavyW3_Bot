namespace Library
{
    public class AbstractPlayerIdManager
    {
        private long _id;
        public long Id 
        {
            get
            {
                return this._id;
            }
            set
            {
                if (this._id == 0)
                {
                    this._id = value;
                }
            }
        }
        public AbstractPlayerIdManager(long id)
        {
            this.Id = id;
        }
    }
}