namespace Library
{
    public class VolcanoEvent : AbstractNextEvent
    {
        public VolcanoEvent()
        :base(new NullNextEvent())
        {
        }
        public override IEvent NextEvent(int random)
        {
            if (random == 3)
            {
                return new Volcano();
            }
            else
            {
                return this.SendNext(random);
            }
        }
    }
}