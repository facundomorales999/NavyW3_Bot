namespace Library
{
    public class KongAttackValidator : IAttackValidator
    {
        public bool AvoidAttack(AbstractAttackable table, AbstractAttacker attack)
        {
            if (attack is GodzillaAttack)
            {
                throw new KongAttackException();
            }
            return false;
        }
    }
}