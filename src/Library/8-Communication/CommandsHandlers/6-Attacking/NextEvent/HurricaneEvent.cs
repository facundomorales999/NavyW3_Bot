namespace Library
{
    public class HurricaneEvent : AbstractNextEvent
    {
        public HurricaneEvent()
        :base(new MeteorShowerEvent())
        {
        }
        public override IEvent NextEvent(int random)
        {
            if (random == 1)
            {
                return new Hurricane();
            }
            else
            {
                return this.SendNext(random);
            }
        }
    }
}