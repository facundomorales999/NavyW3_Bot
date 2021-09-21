namespace Library
{
    public class HeadAddValidator : AbstractItemToAddValidator
    {
        public HeadAddValidator()
        : base(new AddValidatorOfAntiaircraftMissile())
        {
        }
        public override IItemValidator Validator(IItem item)
        {
            return this.SendNext(item);
        }
    }
}