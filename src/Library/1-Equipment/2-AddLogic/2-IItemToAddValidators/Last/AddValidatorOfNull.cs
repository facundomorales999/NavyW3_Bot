using System;

namespace Library
{
    public class AddValidatorOfNull : AbstractItemToAddValidator
    {
        public AddValidatorOfNull()
        : base(null)
        {
        }
        public override IItemValidator Validator(IItem item)
        {
            throw new NotImplementedException();
        }
    }
}