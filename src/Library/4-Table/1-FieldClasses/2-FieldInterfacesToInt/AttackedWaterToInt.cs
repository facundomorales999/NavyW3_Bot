namespace Library
{
    public class AttackedWaterToInt : AbstractFieldInterfaceToInt
    {
        public AttackedWaterToInt()
        :base(new DeadVesselToInt())
        {
        }

        public override int Convert(IField field)
        {
            if (field is AttackedWater)
            {
                return 1;
            }
            else
            {
                return this.SendNext(field);
            }
        }
    }
}