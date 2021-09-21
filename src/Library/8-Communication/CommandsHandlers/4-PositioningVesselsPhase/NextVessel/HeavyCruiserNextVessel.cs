using System.Collections.ObjectModel;

namespace Library
{
    public class HeavyCruiserNextVessel : AbstractNextVessel
    {
        public HeavyCruiserNextVessel()
        :base(new LightCruiserNextVessel())
        {
        }
        public override AbstractVessel NextVessel(ReadOnlyCollection<AbstractVessel> added)
        {
            foreach(AbstractVessel notToAdd in added)
            {
                if(notToAdd is HeavyCruiser)
                {
                    return this.SendNext(added);
                }
            }
            return new HeavyCruiser();
        }
    }
}