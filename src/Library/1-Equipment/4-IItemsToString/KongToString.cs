using System.IO;

namespace Library
{
    public class KongToString: AbstractIItemsToString
    {
        public KongToString()
        :base(new SateliteLockToString())
        {
        }
        public override string ToString(IItem item, string lang)
        {
            if (item is Kong)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Items.txt")[3];
            }
            else
            {
                return this.SendNext(item, lang);
            }
        }
    }
}