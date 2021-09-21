namespace Library
{
    public class HeadFieldInterfacesToEmoji : AbstractFieldInterfaceToEmoji
    {
        public HeadFieldInterfacesToEmoji()
        :base(new AttackableWaterToEmoji())
        {

        }
        public override string Convert(IField field)
        {
            return this.SendNext(field);
        }
    }
}