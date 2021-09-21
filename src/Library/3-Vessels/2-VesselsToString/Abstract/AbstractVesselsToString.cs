namespace Library
{
    public abstract class AbstractVesselsToString
    {
        private AbstractVesselsToString _next;
        public AbstractVesselsToString(AbstractVesselsToString next)
        {
            this._next = next;
        }
        public abstract string ToString(AbstractVessel vessel, string lang);
        public string SendNext(AbstractVessel vessel, string lang)
        {
            return this._next.ToString(vessel, lang);
        }
    }
}