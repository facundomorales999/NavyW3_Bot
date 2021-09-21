using System.IO;

namespace Library
{
    public class NoTwoMissileExceptionToString : AbstractVesselAttackExceptionToString
    {
        public NoTwoMissileExceptionToString()
        :base(new NullVesselAttackExceptionToString())
        {
        }
        public override string ToString(VesselAttackException exception, string lang)
        {
            if (exception is NoTwoMissileException)
            {
                return File.ReadAllLines(@"..\..\..\..\..\language"+lang+@"\VesselsAttackException.txt")[2];
            }
            else
            {
                return this.SendNext(exception, lang);
            }
        }
    }
}