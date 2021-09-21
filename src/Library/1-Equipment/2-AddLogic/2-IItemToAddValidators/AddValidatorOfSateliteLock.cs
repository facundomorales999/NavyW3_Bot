namespace Library
{
    public class AddValidatorOfSateliteLock : AbstractItemToAddValidator
    {
        public AddValidatorOfSateliteLock()
        : base(new AddValidatorOfNull())
        {
        }
        public override IItemValidator Validator(IItem item)
        {
            if (item is SateliteLock)
            {
                return new SateliteLockValidator();
            }
            else
            {
                return SendNext(item);
            }
        }
    }
}