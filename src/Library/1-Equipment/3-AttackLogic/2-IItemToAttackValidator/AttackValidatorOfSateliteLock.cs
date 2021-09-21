namespace Library
{
    public class AttackValidatorOfSateliteLock : AbstractItemToAttackValidator
    {
        public AttackValidatorOfSateliteLock()
        : base(new AttackValidatorOfNull ())
        {
        }
        public override IAttackValidator Validator(IItem item)
        {
            if (item is SateliteLock)
            {
                return new SateliteLockAttackValidator();
            }
            else
            {
                return SendNext(item);
            }
        }
    }
}