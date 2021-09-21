namespace Library
{
    public class HeadVesselAttackExceptionToString : AbstractVesselAttackExceptionToString
    {
        public HeadVesselAttackExceptionToString()
        :base(new NoOneLoadExceptionToString())
        {
        }
        public override string ToString(VesselAttackException exception, string lang)
        {
            return this.SendNext(exception, lang);
        }
    }
}