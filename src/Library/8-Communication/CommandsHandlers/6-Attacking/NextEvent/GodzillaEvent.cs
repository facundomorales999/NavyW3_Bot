namespace Library
{
    public class GodzillaEvent : AbstractNextEvent
    {
        public GodzillaEvent()
        :base(new HurricaneEvent())
        {
        }
        public override IEvent NextEvent(int random)
        {
            if (random == 0)
            {
                return new Godzilla();
            }
            else
            {
                return this.SendNext(random);
            }
        }
    }
}