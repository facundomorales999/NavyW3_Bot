namespace Library
{
    public class HeadIItemsToString : AbstractIItemsToString
    {
        public HeadIItemsToString()
        :base(new AntiaircraftMissileToString())
        {
        }
        public override string ToString(IItem item, string lang)
        {
            return this.SendNext(item, lang);
        }
    }
}