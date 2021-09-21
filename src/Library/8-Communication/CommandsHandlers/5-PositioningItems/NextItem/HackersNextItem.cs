namespace Library
{
    public class HackersNextItem : AbstractNextItem
    {
        public HackersNextItem()
        :base(new KongNextItem())
        {
        }
        public override IItem NextItem(int random)
        {
            if (random == 2)
            {
                return new Hackers();
            }
            else
            {
                return this.SendNext(random);
            }
        }
    }
}