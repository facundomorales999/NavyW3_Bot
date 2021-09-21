using System.IO;

namespace Library
{
    public class BlockedVesselExceptionToString : AbstractItemValidatorsExceptionsToString
    {
        public BlockedVesselExceptionToString()
        :base(new NeededEmptyVesselExceptionToString())
        {
        }
        public override string ToString(ItemAddException exception, string lang)
        {
            if (exception is BlockedVesselException)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\ItemExceptions.txt")[0];
            }
            else 
            {
                return this.SendNext(exception, lang);
            }
        }
    }
}