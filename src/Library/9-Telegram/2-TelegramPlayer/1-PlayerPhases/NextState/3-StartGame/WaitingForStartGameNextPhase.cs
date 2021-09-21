namespace Library
{
    public class WaitingForStartGameNextPhase : AbstractNextPhase
    {
        public WaitingForStartGameNextPhase()
        :base(new PositioningVesselsNextPhase())
        {
        }
        public override IPhase NextPhase(IPhase phase)
        {
            if (phase is WaitingForStartGamePhase)
            {
                return new PositioningVesselsPhase();
            }
            else
            {
                return this.SendNext(phase);
            }
        }
    }
}