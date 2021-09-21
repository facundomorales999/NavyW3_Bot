using System.IO;

namespace Library
{
    public class ArmorToString: AbstractIItemsToString
    {
        public ArmorToString()
        :base(new HackersToString())
        {
        }
        public override string ToString(IItem item, string lang)
        {
            if (item is Armor)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Items.txt")[1];
            }
            else
            {
                return this.SendNext(item, lang);
            }
        }
    }
}