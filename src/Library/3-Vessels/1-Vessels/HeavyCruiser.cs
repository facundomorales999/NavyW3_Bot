namespace Library
{
    public class HeavyCruiser : AbstractVessel
    {
        public HeavyCruiser()
        : base(3, 2)
        {
        }
        public override void LaunchMissile(AbstractTable table, int x, int y)
        {
            AbstractAttacker missile1 = new MissileAttack();
            AbstractAttacker missile2 = new MissileAttack();
            table.AttackAt(x, y, missile1);
            table.AttackAt(x, y, missile2);
        }
    }
}