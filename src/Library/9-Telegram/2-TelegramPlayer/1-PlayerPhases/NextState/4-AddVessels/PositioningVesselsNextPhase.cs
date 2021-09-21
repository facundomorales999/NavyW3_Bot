namespace Library
{
    public class PositioningVesselsNextPhase : AbstractNextPhase
    {
        public PositioningVesselsNextPhase()
        :base(new PositioningItemsNextPhase())
        {
        }
        public override IPhase NextPhase(IPhase phase)
        {
            if (phase is PositioningVesselsPhase)
            {
                return new PositioningItemsPhase();
            }
            else
            {
                return this.SendNext(phase);
            }
        }
    }
}