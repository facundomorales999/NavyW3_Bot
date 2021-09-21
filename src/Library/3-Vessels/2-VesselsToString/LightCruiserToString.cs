using System.IO;

namespace Library
{
    public class LightCruiserToString : AbstractVesselsToString
    {
        public LightCruiserToString()
        :base(new PuntoonToString())
        {
        }
        public override string ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is LightCruiser)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Vessels.txt")[3];
            }
            else
            {
                return this.SendNext(vessel,lang);
            }
        }
    }
}