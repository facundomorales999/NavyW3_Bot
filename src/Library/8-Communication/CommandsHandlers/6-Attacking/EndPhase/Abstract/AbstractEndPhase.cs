
using System.Collections.ObjectModel;

namespace Library
{
    public abstract class AbstractEndPhase
    {
        private AbstractEndPhase _next;
        public AbstractEndPhase(AbstractEndPhase next)
        {
            this._next = next;
        }
        public abstract void DoEndPhase(ReadOnlyCollection<AbstractPlayer> players);
        public void SendNext(ReadOnlyCollection<AbstractPlayer> players)
        {
            this._next.DoEndPhase(players);
        }
    }
}