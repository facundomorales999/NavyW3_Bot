namespace Library
{
    public class Submarine : AbstractVessel
    {
        public Submarine()
        : base(4, 1)
        {
        }
        public override void LaunchMissile(AbstractTable table, int x, int y)
        {
            AbstractAttacker missile = new MissileAttack();
            table.AttackAt(x, y, missile);
        }
        public override void ThrowLoad(AbstractTable table, int x, int y)
        {
            AbstractAttacker load = new LoadAttack();
            table.AttackAt(x, y, load);
        }
        public override bool ReceiveAttackAt(AbstractAttackable table, AbstractAttacker attack)
        {
            if (!(attack is MissileAttack))
            {
                return base.ReceiveAttackAt(table, attack);
            }
            return false;
        }
    }
}