using System.Collections.ObjectModel;

namespace Library
{
    public class NullNextVessel : AbstractNextVessel
    {
        public NullNextVessel()
        :base(null)
        {
        }
        public override AbstractVessel NextVessel(ReadOnlyCollection<AbstractVessel> added)
        {
            return null;
        }

    }
}