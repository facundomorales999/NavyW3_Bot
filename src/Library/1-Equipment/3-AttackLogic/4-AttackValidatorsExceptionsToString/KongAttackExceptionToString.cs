using System.IO;

namespace Library
{
    public class KongAttackExceptionToString : AbstractAttackValidatorsExceptionsToString
    {
        public KongAttackExceptionToString()
        : base(new SateliteLockAttackExceptionToString())
        {
        }
        public override string ToString(AttackException exception, string lang)
        {
            if (exception is KongAttackException)
            {
                return File.ReadAllLines(@"..\..\language\" + lang + @"\AttackExceptions.txt")[2];
            }
            else
            {
                return this.SendNext(exception,lang);
            }
        }
    }
}