namespace Library
{
    public class HeadVesselsToString : AbstractVesselsToString
    {
        public HeadVesselsToString()
        :base(new BattleshipToString())
        {
        }
        public override string ToString(AbstractVessel vessel, string lang)
        {
            return this.SendNext(vessel, lang);
        }
    }
}