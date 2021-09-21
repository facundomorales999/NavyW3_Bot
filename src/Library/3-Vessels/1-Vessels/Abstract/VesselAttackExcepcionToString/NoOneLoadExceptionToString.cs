using System.IO;

namespace Library
{
    public class NoOneLoadExceptionToString : AbstractVesselAttackExceptionToString
    {
        public NoOneLoadExceptionToString()
        :base(new NoOneMissileExceptionToString())
        {
        }
        public override string ToString(VesselAttackException exception, string lang)
        {
            if (exception is NoOneLoadException)
            {
                return File.ReadAllLines(@"..\..\..\..\..\language"+lang+@"\VesselsAttackException.txt")[0];
            }
            else
            {
                return this.SendNext(exception, lang);
            }
        }
    }
}