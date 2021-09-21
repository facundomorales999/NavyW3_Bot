namespace Library
{
    public abstract class AbstractFieldInterfaceToEmoji
    {
        private AbstractFieldInterfaceToEmoji _next;
        public AbstractFieldInterfaceToEmoji(AbstractFieldInterfaceToEmoji next)
        {
            this._next = next;
        }
        public abstract string Convert(IField field);
        public string SendNext(IField field)
        {
            return this._next.Convert(field);
        }
    }
}