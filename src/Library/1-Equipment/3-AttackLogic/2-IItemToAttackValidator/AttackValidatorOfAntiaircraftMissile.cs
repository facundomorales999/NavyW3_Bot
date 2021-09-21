namespace Library
{
    public class AttackValidatorOfAntiaircraftMissile : AbstractItemToAttackValidator
    {
        public AttackValidatorOfAntiaircraftMissile()
        : base(new AttackValidatorOfArmor())
        {
        }
        public override IAttackValidator Validator(IItem item)
        {
            if (item is AntiaircraftMissile)
            {
                return new AntiaircraftMissileAttackValidator();
            }
            else
            {
                return SendNext(item);
            }
        }
    }
}