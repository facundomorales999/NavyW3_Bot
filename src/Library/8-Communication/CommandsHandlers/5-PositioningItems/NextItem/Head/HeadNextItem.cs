namespace Library
{
    public class HeadNextItem : AbstractNextItem
    {
        public HeadNextItem()
        :base(new AntiaircraftMissileNextItem())
        {
        }
        public override IItem NextItem(int random)
        {
            return this.SendNext(random);
        }
    }
}