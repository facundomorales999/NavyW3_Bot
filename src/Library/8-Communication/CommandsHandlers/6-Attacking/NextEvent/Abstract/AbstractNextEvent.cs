namespace Library
{
    public abstract class AbstractNextEvent
    {
        private AbstractNextEvent _next;
        public AbstractNextEvent(AbstractNextEvent next)
        {
            this._next = next;
        }
        public abstract IEvent NextEvent(int random);
        public IEvent SendNext(int random)
        {
            return this._next.NextEvent(random);
        }
    }
}