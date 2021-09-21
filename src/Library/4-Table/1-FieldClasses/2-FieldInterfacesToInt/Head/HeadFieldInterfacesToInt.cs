namespace Library
{
    public class HeadFieldInterfacesToInt : AbstractFieldInterfaceToInt
    {
        public HeadFieldInterfacesToInt()
        :base(new AttackableWaterToInt())
        {

        }
        public override int Convert(IField field)
        {
            return this.SendNext(field);
        }
    }
}