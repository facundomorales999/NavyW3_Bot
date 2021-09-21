using System.Collections.ObjectModel;

namespace Library
{
    public class FrigateNextVessel : AbstractNextVessel
    {
        public FrigateNextVessel()
        :base(new HeavyCruiserNextVessel())
        {
        }
        public override AbstractVessel NextVessel(ReadOnlyCollection<AbstractVessel> added)
        {
            foreach(AbstractVessel notToAdd in added)
            {
                if(notToAdd is Frigate)
                {
                    return this.SendNext(added);
                }
            }
            return new Frigate();
        }
    }
}