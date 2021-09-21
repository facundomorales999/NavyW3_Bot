using System.Collections.ObjectModel;

namespace Library
{
    public class LightCruiserNextVessel : AbstractNextVessel
    {
        public LightCruiserNextVessel()
        :base(new PuntoonNextVessel())
        {
        }
        public override AbstractVessel NextVessel(ReadOnlyCollection<AbstractVessel> added)
        {
            foreach(AbstractVessel notToAdd in added)
            {
                if(notToAdd is LightCruiser)
                {
                    return this.SendNext(added);
                }
            }
            return new LightCruiser();
        }
    }
}