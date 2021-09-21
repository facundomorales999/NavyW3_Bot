using System.Collections.ObjectModel;

namespace Library
{
    public interface IEvent
    {
        public void DoEvent(ReadOnlyCollection<AbstractPlayer> participants);
    }
}