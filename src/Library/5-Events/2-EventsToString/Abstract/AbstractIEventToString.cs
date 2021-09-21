namespace Library
{
    public abstract class AbstractIEventToString
    {
        private AbstractIEventToString _next;
        public AbstractIEventToString(AbstractIEventToString next)
        {
            this._next = next;
        }
        public abstract string ToString(IEvent catastrophe, string lang);
        public string SendNext(IEvent catastrophe, string lang)
        {
            return this._next.ToString();
        }
    }
}