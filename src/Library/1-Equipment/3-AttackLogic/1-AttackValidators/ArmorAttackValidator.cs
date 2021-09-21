namespace Library
{
    public class ArmorAttackValidator : IAttackValidator
    {
        public bool AvoidAttack(AbstractAttackable table, AbstractAttacker attack)
        {
            if (attack is MissileAttack || attack is LoadAttack)
            {
                throw new ArmorAttackException();
            }
            return false;
        }
    }
}