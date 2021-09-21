using System.IO;

namespace Library
{
    public class NoRepetitiveItemExceptionToString : AbstractItemValidatorsExceptionsToString
    {
        public NoRepetitiveItemExceptionToString()
        : base(new TooShortVesselExceptionToString())
        {
        }
        public override string ToString(ItemAddException exception, string lang)
        {
            if (exception is NoRepetitiveItemException)
            {
                return File.ReadAllLines(@"..\..\language\" + lang + @"\ItemExceptions.txt")[3];
            }
            else
            {
                return this.SendNext(exception,lang);
            }
        }
    }
}