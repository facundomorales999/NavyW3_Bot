using System.Collections.ObjectModel;

namespace Library
{
    public class PuntoonNextVessel : AbstractNextVessel
    {
        public PuntoonNextVessel()
        :base(new SubmarineNextVessel())
        {
        }
        public override AbstractVessel NextVessel(ReadOnlyCollection<AbstractVessel> added)
        {
            foreach(AbstractVessel notToAdd in added)
            {
                if(notToAdd is Puntoon)
                {
                    return this.SendNext(added);
                }
            }
            return new Puntoon();
        }
    }
}