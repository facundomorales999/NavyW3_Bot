namespace Library
{
    public class SateliteLockAttackValidator : IAttackValidator
    {
        public bool AvoidAttack(AbstractAttackable table, AbstractAttacker attack)
        {
            if (attack is MissileAttack || attack is LoadAttack)
            {
                table.RandomAttack(attack);
                throw new SateliteLockAttackException();
            }
           return false;
        }
    }
}