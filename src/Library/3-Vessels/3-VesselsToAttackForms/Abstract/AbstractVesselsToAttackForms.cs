using System.Collections.Generic;

namespace Library
{
    public abstract class AbstractVesselsToAttackForms
    {
        private AbstractVesselsToAttackForms _next;
        public AbstractVesselsToAttackForms(AbstractVesselsToAttackForms next)
        {
            this._next = next;
        }
        public abstract List<string> ToString(AbstractVessel vessel, string lang);
        public List<string> SendNext(AbstractVessel vessel, string lang)
        {
            return this._next.ToString(vessel, lang);
        }
    }
}