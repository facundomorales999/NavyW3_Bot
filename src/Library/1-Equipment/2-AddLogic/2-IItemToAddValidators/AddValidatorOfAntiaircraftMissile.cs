namespace Library
{
    public class AddValidatorOfAntiaircraftMissile : AbstractItemToAddValidator
    {
        public AddValidatorOfAntiaircraftMissile()
        : base(new AddValidatorOfArmor())
        {
        }
        public override IItemValidator Validator(IItem item)
        {
            if (item is AntiaircraftMissile)
            {
                return new AntiaircraftMissileValidator();
            }
            else
            {
                return SendNext(item);
            }
        }
    }
}