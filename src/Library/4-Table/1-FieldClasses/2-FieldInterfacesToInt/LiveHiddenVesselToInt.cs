namespace Library
{
    public class LiveHiddenVesselToInt : AbstractFieldInterfaceToInt
    {
        public LiveHiddenVesselToInt()
        :base(new UnattackableWaterToInt())
        {
        }

        public override int Convert(IField field)
        {
            if (field is LiveHiddenVessel)
            {
                return 4;
            }
            else
            {
                return this.SendNext(field);
            }
        }
    }
}