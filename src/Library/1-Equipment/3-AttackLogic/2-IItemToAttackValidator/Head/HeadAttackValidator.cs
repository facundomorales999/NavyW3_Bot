namespace Library
{
    public class HeadAttackValidator : AbstractItemToAttackValidator
    {
        public HeadAttackValidator()
        : base(new AttackValidatorOfAntiaircraftMissile ())
        {
        }
        public override IAttackValidator Validator(IItem item)
        {
            return this.SendNext(item);
        }
    }
}