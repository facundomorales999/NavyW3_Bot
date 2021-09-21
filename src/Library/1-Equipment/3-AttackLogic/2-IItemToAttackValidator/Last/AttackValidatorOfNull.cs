using System;

namespace Library
{
    public class AttackValidatorOfNull : AbstractItemToAttackValidator
    {
        public AttackValidatorOfNull()
        : base(null)
        {
        }
        public override IAttackValidator Validator(IItem item)
        {
            throw new NotImplementedException();
        }
    }
}