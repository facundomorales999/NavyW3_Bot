namespace Library
{
    public abstract class AbstractNextPhase
    {
        private AbstractNextPhase _next;
        public AbstractNextPhase(AbstractNextPhase next)
        {
            this._next = next;
        }
        public abstract IPhase NextPhase(IPhase phase);
        public IPhase SendNext(IPhase phase)
        {
            return this._next.NextPhase(phase);
        }
    }
}