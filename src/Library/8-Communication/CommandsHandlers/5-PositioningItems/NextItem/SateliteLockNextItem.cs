namespace Library
{
    public class SateliteLockNextItem : AbstractNextItem
    {
        public SateliteLockNextItem()
        :base(new NullNextItem())
        {
        }
        public override IItem NextItem(int random)
        {
            if (random == 4)
            {
                return new SateliteLock();
            }
            else
            {
                return this.SendNext(random);
            }
        }
    }
}