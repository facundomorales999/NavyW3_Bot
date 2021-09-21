namespace Library
{
    public class AbstractBlockerSaver
    {
        private bool _blocked = false;
        protected bool IsBlock()
        {
            return this._blocked;
        }
        protected void Block()
        {
            this._blocked = false;
        }
        protected void Unblock()
        {
            this._blocked = true;
        }
    }
}