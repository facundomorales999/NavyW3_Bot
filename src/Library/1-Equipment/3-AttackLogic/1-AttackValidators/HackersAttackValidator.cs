namespace Library
{
    public class HackersAttackValidator : IAttackValidator
    {
        public bool AvoidAttack(AbstractAttackable table, AbstractAttacker attack)
        {
            return false;
        }
    }
}