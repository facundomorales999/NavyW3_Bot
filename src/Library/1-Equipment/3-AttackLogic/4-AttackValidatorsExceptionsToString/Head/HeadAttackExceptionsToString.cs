namespace Library
{
    public class HeadAttackExceptionsToString : AbstractAttackValidatorsExceptionsToString
    {
        public HeadAttackExceptionsToString()
        :base(new AntiaircraftMissileExceptionToString())
        {
        }
        public override string ToString(AttackException exception, string language)
        {
            return this.SendNext(exception, language);
        }
    }
}