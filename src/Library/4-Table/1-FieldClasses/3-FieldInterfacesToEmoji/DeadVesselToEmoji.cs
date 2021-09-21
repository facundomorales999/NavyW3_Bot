namespace Library
{
    public class DeadVesselToEmoji : AbstractFieldInterfaceToEmoji
    {
        public DeadVesselToEmoji()
        :base(new LivedVesselToEmoji())
        {
        }

        public override string Convert(IField field)
        {
            if (field is DeadVessel)
            {
                return "\U0001F480";
            }
            else
            {
                return this.SendNext(field);
            }
        }
    }
}