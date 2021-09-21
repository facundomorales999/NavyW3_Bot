using System;

namespace Library
{
    public class NullNextEvent : AbstractNextEvent
    {
        public NullNextEvent()
        :base(null)
        {
        }
        public override IEvent NextEvent(int random)
        {
            throw new NotImplementedException();
        }
    }
}