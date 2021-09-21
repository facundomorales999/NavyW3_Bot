
using System.Collections.ObjectModel;

namespace Library
{
    public class NullEndPhase : AbstractEndPhase
    {
        public NullEndPhase()
        :base(null)
        {
        }
        public override void DoEndPhase(ReadOnlyCollection<AbstractPlayer> players)
        {
            
        }
    }
}