namespace Library
{
    public abstract class AbstractItemToAttackValidator
    {
        private AbstractItemToAttackValidator _next;
        protected AbstractItemToAttackValidator(AbstractItemToAttackValidator next)
        {
            this._next = next;
        }
        public abstract IAttackValidator Validator(IItem item);
        protected IAttackValidator SendNext(IItem item)
        {
            return this._next.Validator(item);
        }
    }
}