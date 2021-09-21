using System.IO;

namespace Library
{
    public class HackersToString: AbstractIItemsToString
    {
        public HackersToString()
        :base(new KongToString())
        {
        }
        public override string ToString(IItem item, string lang)
        {
            if (item is Hackers)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Items.txt")[2];
            }
            else
            {
                return this.SendNext(item, lang);
            }
        }
    }
}