using System.IO;

namespace Library
{
    public class NoEmptyPositionExceptionToString : AbstractItemValidatorsExceptionsToString
    {
        public NoEmptyPositionExceptionToString()
        : base(new NoRepetitiveItemExceptionToString())
        {
        }
        public override string ToString(ItemAddException exception, string lang)
        {
            if (exception is NoEmptyPositionException)
            {
                return File.ReadAllLines(@"..\..\language\" + lang + @"\ItemExceptions.txt")[2];
            }
            else
            {
                return this.SendNext(exception, lang);
            }
        }
    }
}