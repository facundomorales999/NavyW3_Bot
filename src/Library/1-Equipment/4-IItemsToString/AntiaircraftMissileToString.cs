using System.IO;

namespace Library
{
    public class AntiaircraftMissileToString: AbstractIItemsToString
    {
        public AntiaircraftMissileToString()
        :base(new ArmorToString())
        {
        }
        public override string ToString(IItem item, string lang)
        {
            if (item is AntiaircraftMissile)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Items.txt")[0];
            }
            else
            {
                return this.SendNext(item, lang);
            }
        }
    }
}