namespace Library
{
    public class MeteorShowerEvent : AbstractNextEvent
    {
        public MeteorShowerEvent()
        :base(new VolcanoEvent())
        {
        }
        public override IEvent NextEvent(int random)
        {
            if (random == 2)
            {
                return new MeteorShower();
            }
            else
            {
                return this.SendNext(random);
            }
        }
    }
}