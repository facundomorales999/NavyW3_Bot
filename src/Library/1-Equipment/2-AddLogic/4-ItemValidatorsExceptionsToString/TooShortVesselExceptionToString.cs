using System.IO;

namespace Library
{
    public class TooShortVesselExceptionToString : AbstractItemValidatorsExceptionsToString
    {
        public TooShortVesselExceptionToString()
        : base(new WrongVesselExceptionToString())
        {
        }
        public override string ToString(ItemAddException exception, string lang)
        {
            if (exception is TooShortVesselException)
            {
                return File.ReadAllLines(@"..\..\language\" + lang + @"\ItemExceptions.txt")[4];
            }
            else
            {
                return this.SendNext(exception,lang);
            }
        }
    }
}