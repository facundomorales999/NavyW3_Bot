using System;

namespace Library
{
    public class NullVesselAttackExceptionToString : AbstractVesselAttackExceptionToString
    {
        public NullVesselAttackExceptionToString()
        :base(null)
        {
        }
        public override string ToString(VesselAttackException exception, string lang)
        {
            throw new NotImplementedException();
        }
    }
}