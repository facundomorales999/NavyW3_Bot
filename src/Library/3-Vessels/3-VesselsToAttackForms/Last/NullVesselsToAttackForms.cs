using System;
using System.Collections.Generic;

namespace Library
{
    public class NullVesselsToAttackForms : AbstractVesselsToAttackForms
    {
        public NullVesselsToAttackForms()
        :base(null)
        {
        }
        public override List<string> ToString(AbstractVessel vessel, string lang)
        {
            throw new NotImplementedException();
        }
    }
}