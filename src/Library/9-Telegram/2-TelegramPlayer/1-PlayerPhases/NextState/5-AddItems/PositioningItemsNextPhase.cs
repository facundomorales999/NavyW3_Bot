namespace Library
{
    public class PositioningItemsNextPhase : AbstractNextPhase
    {
        public PositioningItemsNextPhase()
        :base(new NullNextPhase())
        {
        }
        public override IPhase NextPhase(IPhase phase)
        {
            if (phase is PositioningItemsPhase)
            {
                return new AttackPhase();
            }
            else
            {
                return this.SendNext(phase);
            }
        }
    }
}