using System.IO;

namespace Library
{
    public class SubmarineToString : AbstractVesselsToString
    {
        public SubmarineToString()
        :base(new NullVesselsToString())
        {
        }
        public override string ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is Submarine)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Vessels.txt")[5];
            }
            else
            {
                return this.SendNext(vessel,lang);
            }
        }
    }
}