using System;
namespace Library
{
    public class NullExceptionToString : AbstractItemValidatorsExceptionsToString
    {
        public NullExceptionToString()
        :base(null)
        {
        }
        public override string ToString(ItemAddException exception, string language)
        {
            throw new NotImplementedException();
        }
    }
}