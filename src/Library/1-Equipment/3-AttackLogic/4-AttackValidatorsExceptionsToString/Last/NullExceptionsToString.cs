using System;
namespace Library
{
    public class NullAttackExceptionToString : AbstractAttackValidatorsExceptionsToString
    {
        public NullAttackExceptionToString()
        :base(null)
        {
        }
        public override string ToString(AttackException exception, string language)
        {
            throw new NotImplementedException();
        }
    }
}