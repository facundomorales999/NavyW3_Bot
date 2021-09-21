namespace Library
{
    public class AttackedWaterToEmoji : AbstractFieldInterfaceToEmoji
    {
        public AttackedWaterToEmoji()
        :base(new DeadVesselToEmoji())
        {
        }

        public override string Convert(IField field)
        {
            if (field is AttackedWater)
            {
                return "\U00002753";
            }
            else
            {
                return this.SendNext(field);
            }
        }
    }
}