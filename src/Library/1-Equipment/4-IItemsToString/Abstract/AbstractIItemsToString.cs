namespace Library
{
    public abstract class AbstractIItemsToString
    {
        private AbstractIItemsToString _next;
        public AbstractIItemsToString(AbstractIItemsToString next)
        {
            this._next = next;
        }
        public abstract string ToString(IItem item, string lang);
        public string SendNext(IItem item, string lang)
        {
            return this._next.ToString(item, lang);
        }
    }
}