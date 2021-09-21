
using System.Collections.ObjectModel;

namespace Library
{
    public class HeadEndPhase : AbstractEndPhase
    {
        public HeadEndPhase()
        :base(new EventEndPhase())
        {
        }
        public override void DoEndPhase(ReadOnlyCollection<AbstractPlayer> players)
        {
            this.SendNext(players);
        }
    }
}