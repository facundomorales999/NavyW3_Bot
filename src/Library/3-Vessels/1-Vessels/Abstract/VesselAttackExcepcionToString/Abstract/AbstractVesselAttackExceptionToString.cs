namespace Library
{
    public abstract class AbstractVesselAttackExceptionToString
    {
        private AbstractVesselAttackExceptionToString _next;
        public AbstractVesselAttackExceptionToString(AbstractVesselAttackExceptionToString next)
        {
            this._next = next;
        }
        public abstract string ToString(VesselAttackException exception, string lang);
        public string SendNext(VesselAttackException exception, string lang)
        {
            return this._next.ToString(exception, lang);
        }
    }
}