namespace Library
{
    public class AttackValidatorOfArmor : AbstractItemToAttackValidator
    {
        public AttackValidatorOfArmor()
        : base(new AttackValidatorOfHackers())
        {
        }
        public override IAttackValidator Validator(IItem item)
        {
            if (item is Armor)
            {
                return new ArmorAttackValidator();
            }
            else
            {
                return SendNext(item);
            }
        }
    }
}