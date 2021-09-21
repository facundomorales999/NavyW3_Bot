namespace Library
{
    public interface IAttackValidator
    {
        public bool AvoidAttack(AbstractAttackable table, AbstractAttacker attack);
    }
}