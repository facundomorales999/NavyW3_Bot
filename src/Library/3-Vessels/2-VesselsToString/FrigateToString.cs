using System.IO;

namespace Library
{
    public class FrigateToString : AbstractVesselsToString
    {
        public FrigateToString()
        :base(new HeavyCruiserToString())
        {
        }
        public override string ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is Frigate)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Vessels.txt")[1];
            }
            else
            {
                return this.SendNext(vessel,lang);
            }
        }
    }
}