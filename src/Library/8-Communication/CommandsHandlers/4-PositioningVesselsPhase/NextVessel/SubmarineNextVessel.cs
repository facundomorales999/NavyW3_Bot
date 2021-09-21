using System.Collections.ObjectModel;

namespace Library
{
    public class SubmarineNextVessel : AbstractNextVessel
    {
        public SubmarineNextVessel()
        :base(new NullNextVessel())
        {
        }
        public override AbstractVessel NextVessel(ReadOnlyCollection<AbstractVessel> added)
        {
            foreach(AbstractVessel notToAdd in added)
            {
                if(notToAdd is Submarine)
                {
                    return this.SendNext(added);
                }
            }
            return new Submarine();
        }
    }
}