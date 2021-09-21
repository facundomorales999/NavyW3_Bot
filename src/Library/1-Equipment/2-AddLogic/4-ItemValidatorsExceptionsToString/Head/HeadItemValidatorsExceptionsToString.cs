namespace Library
{
    public class HeadItemValidatorsExceptionsToString : AbstractItemValidatorsExceptionsToString
    {
        public HeadItemValidatorsExceptionsToString()
        :base(new BlockedVesselExceptionToString())
        {
        }
        public override string ToString(ItemAddException exception, string language)
        {
            return this.SendNext(exception, language);
        }
    }
}