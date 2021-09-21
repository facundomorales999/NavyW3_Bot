using System.IO;

namespace Library
{
    public class HeavyCruiserToString : AbstractVesselsToString
    {
        public HeavyCruiserToString()
        :base(new LightCruiserToString())
        {
        }
        public override string ToString(AbstractVessel vessel, string lang)
        {
            if (vessel is HeavyCruiser)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Vessels.txt")[2];
            }
            else
            {
                return this.SendNext(vessel,lang);
            }
        }
    }
}