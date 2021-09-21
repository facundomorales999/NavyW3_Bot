namespace Library
{
    public class AddValidatorOfArmor : AbstractItemToAddValidator
    {
        public AddValidatorOfArmor()
        : base(new AddValidatorOfHackers())
        {
        }
        public override IItemValidator Validator(IItem item)
        {
            if (item is Armor)
            {
                return new ArmorValidator();
            }
            else
            {
                return SendNext(item);
            }
        }
    }
}