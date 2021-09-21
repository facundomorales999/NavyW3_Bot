using System.IO;

namespace Library
{
    public class NeededEmptyVesselExceptionToString : AbstractItemValidatorsExceptionsToString
    {
        public NeededEmptyVesselExceptionToString()
        :base(new NoEmptyPositionExceptionToString())
        {
        }
        public override string ToString(ItemAddException exception, string lang)
        {
            if (exception is NeededEmptyVesselException)
            {
                return File.ReadAllLines(@"\..\..\language\"+lang+@"\ItemExceptions.txt")[1];
            }
            else 
            {
                return this.SendNext(exception, lang);
            }
        }
    }
}