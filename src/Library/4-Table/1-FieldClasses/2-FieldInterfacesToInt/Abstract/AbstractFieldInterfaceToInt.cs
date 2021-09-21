namespace Library
{
    public abstract class AbstractFieldInterfaceToInt
    {
        private AbstractFieldInterfaceToInt _next;
        public AbstractFieldInterfaceToInt(AbstractFieldInterfaceToInt next)
        {
            this._next = next;
        }
        public abstract int Convert(IField field);
        public int SendNext(IField field)
        {
            return this._next.Convert(field);
        }
    }
}