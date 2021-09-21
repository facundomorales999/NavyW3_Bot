using System.IO;

namespace Library
{
    public class BattleshipToString : AbstractVesselsToString
    {
        public BattleshipToString()
        :base(new FrigateToString())
        {
        }
        public override string ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is Battleship)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Vessels.txt")[0];
            }
            else
            {
                return this.SendNext(vessel,lang);
            }
        }
    }
}