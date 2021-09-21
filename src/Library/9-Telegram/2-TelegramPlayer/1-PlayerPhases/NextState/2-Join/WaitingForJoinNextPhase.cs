namespace Library
{
    public class WaitingForJoinNextPhase : AbstractNextPhase
    {
        public WaitingForJoinNextPhase()
        :base(new WaitingForStartGameNextPhase())
        {
        }
        public override IPhase NextPhase(IPhase phase)
        {
            if (phase is WaitingForJoinPhase)
            {
                return new WaitingForStartGamePhase();
            }
            else
            {
                return this.SendNext(phase);
            }
        }
    }
}