using System.IO;

namespace Library
{
    public class PuntoonToString : AbstractVesselsToString
    {
        public PuntoonToString()
        :base(new SubmarineToString())
        {
        }
        public override string ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is Puntoon)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Vessels.txt")[4];
            }
            else
            {
                return this.SendNext(vessel,lang);
            }
        }
    }
}