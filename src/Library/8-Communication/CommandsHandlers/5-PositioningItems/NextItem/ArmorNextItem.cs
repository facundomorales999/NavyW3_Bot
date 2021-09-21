namespace Library
{
    public class ArmorNextItem : AbstractNextItem
    {
        public ArmorNextItem()
        :base(new HackersNextItem())
        {
        }
        public override IItem NextItem(int random)
        {
            if (random == 1)
            {
                return new Armor();
            }
            else
            {
                return this.SendNext(random);
            }
        }
    }
}