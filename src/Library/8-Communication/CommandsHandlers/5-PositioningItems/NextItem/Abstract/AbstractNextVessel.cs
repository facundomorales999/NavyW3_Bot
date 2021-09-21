namespace Library
{
    public abstract class AbstractNextItem
    {
        private AbstractNextItem _next;
        public AbstractNextItem(AbstractNextItem next)
        {
            this._next = next;
        }
        public abstract IItem NextItem(int random);
        public IItem SendNext(int random)
        {
            return this._next.NextItem(random);
        }
    }
}