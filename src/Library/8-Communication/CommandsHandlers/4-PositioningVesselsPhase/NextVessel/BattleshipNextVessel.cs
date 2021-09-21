using System.Collections.ObjectModel;

namespace Library
{
    public class BattleshipNextVessel : AbstractNextVessel
    {
        public BattleshipNextVessel()
        :base(new FrigateNextVessel())
        {
        }
        public override AbstractVessel NextVessel(ReadOnlyCollection<AbstractVessel> added)
        {
            foreach(AbstractVessel notToAdd in added)
            {
                if(notToAdd is Battleship)
                {
                    return this.SendNext(added);
                }
            }
            return new Battleship();
        }
    }
}