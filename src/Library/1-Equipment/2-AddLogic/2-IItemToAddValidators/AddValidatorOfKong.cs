namespace Library
{
    public class AddValidatorOfKong : AbstractItemToAddValidator
    {
        public AddValidatorOfKong()
        : base(new AddValidatorOfSateliteLock())
        {
        }
        public override IItemValidator Validator(IItem item)
        {
            if (item is Kong)
            {
                return new KongValidator();
            }
            else
            {
                return SendNext(item);
            }
        }
    }
}