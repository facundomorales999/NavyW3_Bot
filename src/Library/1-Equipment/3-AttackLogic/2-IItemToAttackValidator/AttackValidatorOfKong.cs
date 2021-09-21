namespace Library
{
    public class AttackValidatorOfKong : AbstractItemToAttackValidator
    {
        public AttackValidatorOfKong()
        : base(new AttackValidatorOfSateliteLock())
        {
        }
        public override IAttackValidator Validator(IItem item)
        {
            if (item is Kong)
            {
                return new KongAttackValidator();
            }
            else
            {
                return SendNext(item);
            }
        }
    }
}