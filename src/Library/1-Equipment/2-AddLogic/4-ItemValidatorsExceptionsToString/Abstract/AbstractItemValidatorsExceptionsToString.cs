namespace Library
{
    public abstract class AbstractItemValidatorsExceptionsToString
    {
        private AbstractItemValidatorsExceptionsToString _next;
        public AbstractItemValidatorsExceptionsToString(AbstractItemValidatorsExceptionsToString next)
        {
            this._next = next;
        }
        public abstract string ToString(ItemAddException exception, string language);
        public string SendNext(ItemAddException exception, string language)
        {
            return this._next.ToString(exception, language);
        }
    }
}