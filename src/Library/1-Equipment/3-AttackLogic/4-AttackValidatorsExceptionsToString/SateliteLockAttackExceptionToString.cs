using System.IO;

namespace Library
{
    public class SateliteLockAttackExceptionToString : AbstractAttackValidatorsExceptionsToString
    {
        public SateliteLockAttackExceptionToString()
        : base(new NullAttackExceptionToString())
        {
        }
        public override string ToString(AttackException exception, string lang)
        {
            if (exception is SateliteLockAttackException)
            {
                return File.ReadAllLines(@"..\..\language\" + lang + @"\AttackExceptions.txt")[3];
            }
            else
            {
                return this.SendNext(exception,lang);
            }
        }
    }
}