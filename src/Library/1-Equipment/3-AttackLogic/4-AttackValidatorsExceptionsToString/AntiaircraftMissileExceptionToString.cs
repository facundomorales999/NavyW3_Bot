using System.IO;

namespace Library
{
    public class AntiaircraftMissileExceptionToString : AbstractAttackValidatorsExceptionsToString
    {
        public AntiaircraftMissileExceptionToString()
        :base(new ArmorAttackExceptionToString())
        {
        }
        public override string ToString(AttackException exception, string lang)
        {
            if (exception is AntiaircraftMissileException)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\AttackExceptions.txt")[0];
            }
            else 
            {
                return this.SendNext(exception, lang);
            }
        }
    }
}