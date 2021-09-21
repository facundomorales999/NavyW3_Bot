using System.IO;

namespace Library
{
    public class WrongVesselExceptionToString : AbstractItemValidatorsExceptionsToString
    {
        public WrongVesselExceptionToString()
        : base(new NullExceptionToString())
        {
        }
        public override string ToString(ItemAddException exception, string lang)
        {
            if (exception is WrongVesselException)
            {
                return File.ReadAllLines(@"..\..\language\" + lang + @"\ItemExceptions.txt")[5];
            }
            else
            {
                return this.SendNext(exception,lang);
            }
        }
    }
}