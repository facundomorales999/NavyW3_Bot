using System.IO;

namespace Library
{
    public class NoOneMissileExceptionToString : AbstractVesselAttackExceptionToString
    {
        public NoOneMissileExceptionToString()
        :base(new NoTwoMissileExceptionToString())
        {
        }
        public override string ToString(VesselAttackException exception, string lang)
        {
            if (exception is NoOneMissileException)
            {
                return File.ReadAllLines(@"..\..\..\..\..\language"+lang+@"\VesselsAttackException.txt")[1];
            }
            else
            {
                return this.SendNext(exception, lang);
            }
        }
    }
}