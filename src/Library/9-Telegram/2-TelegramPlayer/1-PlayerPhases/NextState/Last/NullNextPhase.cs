using System;

namespace Library
{
    public class NullNextPhase : AbstractNextPhase
    {
        public NullNextPhase()
        :base(null)
        {
        }
        public override IPhase NextPhase(IPhase phase)
        {
            throw new NotImplementedException();
        }
    }
}