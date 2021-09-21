namespace Library
{
    public class AttackValidatorOfHackers : AbstractItemToAttackValidator
    {
        public AttackValidatorOfHackers()
        : base(new AttackValidatorOfKong())
        {
        }
        public override IAttackValidator Validator(IItem item)
        {
            if (item is Hackers)
            {
                return new HackersAttackValidator();
            }
            else
            {
                return SendNext(item);
            }
        }
    }
}