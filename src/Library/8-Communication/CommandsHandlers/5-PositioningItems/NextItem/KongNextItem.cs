namespace Library
{
    public class KongNextItem : AbstractNextItem
    {
        public KongNextItem()
        :base(new SateliteLockNextItem())
        {
        }
        public override IItem NextItem(int random)
        {
            if (random == 3)
            {
                return new Kong();
            }
            else
            {
                return this.SendNext(random);
            }
        }
    }
}