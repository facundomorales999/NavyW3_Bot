using System.Collections.ObjectModel;

namespace Library
{
    public class HeadNextVessel : AbstractNextVessel
    {
        public HeadNextVessel()
        :base(new BattleshipNextVessel())
        {
        }
        public override AbstractVessel NextVessel(ReadOnlyCollection<AbstractVessel> added)
        {
            return this.SendNext(added);
        }

    }
}