namespace Library
{
    public class NullFieldInterfaceToInt : AbstractFieldInterfaceToInt
    {
        public NullFieldInterfaceToInt()
        :base(null)
        {
        }

        public override int Convert(IField field)
        {
            return 9999;
        }
    }
}