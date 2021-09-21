namespace Library
{
    public abstract class AbstractAttackValidatorsExceptionsToString
    {
        private AbstractAttackValidatorsExceptionsToString _next;
        public AbstractAttackValidatorsExceptionsToString(AbstractAttackValidatorsExceptionsToString next)
        {
            this._next = next;
        }
        public abstract string ToString(AttackException exception, string language);
        public string SendNext(AttackException exception, string language)
        {
            return this._next.ToString(exception, language);
        }
    }
}