namespace Library
{
    public class LightCruiser : AbstractVessel
    {
        public LightCruiser()
        : base(5, 1)
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
    }
}