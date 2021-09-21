namespace Library
{
    public abstract class AbstractMessageHandler
    {
        private AbstractMessageHandler _next;
        public AbstractMessageHandler(AbstractMessageHandler next)
        {
            this._next = next;
        }
        public abstract string[] MessagesOf(IPhase phase, string lang);
        public string[] SendNext(IPhase phase, string lang)
        {
            return this._next.MessagesOf(phase, lang);
        }

    }   
}