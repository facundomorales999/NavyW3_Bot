namespace Library
{
    public class LiveHiddenVesselToEmoji : AbstractFieldInterfaceToEmoji
    {
        public LiveHiddenVesselToEmoji()
        :base(new UnattackableWaterToEmoji())
        {
        }

        public override string Convert(IField field)
        {
            if (field is LiveHiddenVessel)
            {
                return "\U0001F6A2";
            }
            else
            {
                return this.SendNext(field);
            }
        }
    }
}