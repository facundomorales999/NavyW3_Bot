namespace Library
{
    public class HeadNextEvent : AbstractNextEvent
    {
        public HeadNextEvent()
        :base(new GodzillaEvent())
        {
        }
        public override IEvent NextEvent(int random)
        {
            return this.SendNext(random);
        }
    }
}