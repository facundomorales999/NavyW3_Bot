namespace Library
{
    public class AddValidatorOfHackers : AbstractItemToAddValidator
    {
        public AddValidatorOfHackers()
        : base(new AddValidatorOfKong())
        {
        }
        public override IItemValidator Validator(IItem item)
        {
            if (item is Hackers)
            {
                return new HackersValidator();
            }
            else
            {
                return SendNext(item);
            }
        }
    }
}