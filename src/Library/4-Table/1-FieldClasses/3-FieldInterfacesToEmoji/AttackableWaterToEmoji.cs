namespace Library
{
    public class AttackableWaterToEmoji : AbstractFieldInterfaceToEmoji
    {
        public AttackableWaterToEmoji()
        :base(new AttackedWaterToEmoji())
        {
        }

        public override string Convert(IField field)
        {
            if (field is AttackableWater)
            {
                return "\U0001F30A";
            }
            else
            {
                return this.SendNext(field);
            }
        }
    }
}