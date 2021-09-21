namespace Library
{
    public class UnattackableWaterToEmoji : AbstractFieldInterfaceToEmoji
    {
        public UnattackableWaterToEmoji()
        :base(new NullFieldInterfaceToEmoji())
        {
        }

        public override string Convert(IField field)
        {
            if (field is UnattackableWater)
            {
                return "\U00002B55";
            }
            else
            {
                return this.SendNext(field);
            }
        }
    }
}