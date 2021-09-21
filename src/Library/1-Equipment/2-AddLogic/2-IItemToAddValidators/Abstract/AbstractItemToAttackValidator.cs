namespace Library
{
    public abstract class AbstractItemToAddValidator
    {
        private AbstractItemToAddValidator _next;
        protected AbstractItemToAddValidator(AbstractItemToAddValidator next)
        {
            this._next = next;
        }
        public abstract IItemValidator Validator(IItem item);
        protected IItemValidator SendNext(IItem item)
        {
            return this._next.Validator(item);
        }
    }
}