namespace Library
{
    public class WaitingForStartNextPhase : AbstractNextPhase
    {
        public WaitingForStartNextPhase()
        :base(new WaitingForJoinNextPhase())
        {
        }
        public override IPhase NextPhase(IPhase phase)
        {
            if (phase is WaitingForStartPhase)
            {
                return new WaitingForJoinPhase();
            }
            else
            {
                return this.SendNext(phase);
            }
        }
    }
}