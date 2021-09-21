using System.Collections.ObjectModel;

namespace Library
{
    public abstract class AbstractNextVessel
    {
        private AbstractNextVessel _next;
        public AbstractNextVessel(AbstractNextVessel next)
        {
            this._next = next;
        }
        public abstract AbstractVessel NextVessel(ReadOnlyCollection<AbstractVessel> added);
        public AbstractVessel SendNext(ReadOnlyCollection<AbstractVessel> added)
        {
            return this._next.NextVessel(added);
        }
    }
}