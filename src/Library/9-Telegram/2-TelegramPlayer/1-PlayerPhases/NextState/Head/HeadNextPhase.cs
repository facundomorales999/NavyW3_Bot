namespace Library
{
    public class HeadNextPhase : AbstractNextPhase
    {
        public HeadNextPhase()
        :base(new WaitingForStartNextPhase())
        {
        }
        public override IPhase NextPhase(IPhase phase)
        {
            return this.SendNext(phase);
        }
    }
}