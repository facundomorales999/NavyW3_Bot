namespace Library
{
    public abstract class AbstractCommandsTranslate
    {
        private AbstractCommandsTranslate _next;
        public AbstractCommandsTranslate(AbstractCommandsTranslate next)
        {
            this._next = next;
        }
        public abstract string Translate(string command, string lang);
        public string SendNext(string command, string lang)
        {
            return this._next.Translate(command, lang);
        }
    }
}