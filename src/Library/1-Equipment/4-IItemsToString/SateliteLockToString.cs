using System.IO;

namespace Library
{
    public class SateliteLockToString: AbstractIItemsToString
    {
        public SateliteLockToString()
        :base(new NullIItemToString())
        {
        }
        public override string ToString(IItem item, string lang)
        {
            if (item is SateliteLock)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Items.txt")[4];
            }
            else
            {
                return this.SendNext(item, lang);
            }
        }
    }
}