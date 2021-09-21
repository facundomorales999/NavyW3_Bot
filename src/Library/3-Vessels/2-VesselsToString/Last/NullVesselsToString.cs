using System;

namespace Library
{
    public class NullVesselsToString : AbstractVesselsToString
    {
        public NullVesselsToString()
        :base(null)
        {
        }
        public override string ToString(AbstractVessel vessel, string lang)
        {
            throw new NotImplementedException();
        }
    }
}