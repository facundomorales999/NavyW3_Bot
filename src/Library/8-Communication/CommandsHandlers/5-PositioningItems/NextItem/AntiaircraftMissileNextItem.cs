namespace Library
{
    public class AntiaircraftMissileNextItem : AbstractNextItem
    {
        public AntiaircraftMissileNextItem()
        :base(new ArmorNextItem())
        {
        }
        public override IItem NextItem(int random)
        {
            if (random == 0)
            {
                return new AntiaircraftMissile();
            }
            else
            {
                return this.SendNext(random);
            }
        }
    }
}