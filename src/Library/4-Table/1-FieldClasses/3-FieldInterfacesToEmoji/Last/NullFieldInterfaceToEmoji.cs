namespace Library
{
    public class NullFieldInterfaceToEmoji : AbstractFieldInterfaceToEmoji
    {
        public NullFieldInterfaceToEmoji()
        :base(null)
        {
        }

        public override string Convert(IField field)
        {
            return "";
        }
    }
}