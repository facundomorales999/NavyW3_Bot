namespace Library
{
    public class AntiaircraftMissileAttackValidator : IAttackValidator
    {
        public bool AvoidAttack(AbstractAttackable table, AbstractAttacker attack)
        {
            if (attack is MissileAttack)
            {
                throw new AntiaircraftMissileException();
            }
            return false;
        }
    }
}