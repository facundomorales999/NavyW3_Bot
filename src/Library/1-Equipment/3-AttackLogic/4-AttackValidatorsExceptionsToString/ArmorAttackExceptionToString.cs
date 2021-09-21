using System.IO;

namespace Library
{
    public class ArmorAttackExceptionToString : AbstractAttackValidatorsExceptionsToString
    {
        public ArmorAttackExceptionToString()
        : base(new KongAttackExceptionToString())
        {
        }
        public override string ToString(AttackException exception, string lang)
        {
            if (exception is ArmorAttackException)
            {
                return File.ReadAllLines(@"..\..\language\" + lang + @"\AttackExceptions.txt")[1];
            }
            else
            {
                return this.SendNext(exception, lang);
            }
        }
    }
}