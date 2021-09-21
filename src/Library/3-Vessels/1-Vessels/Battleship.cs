namespace Library
{
    public class Battleship : AbstractVessel
    {
        public Battleship()
        : base(6, 1)
        {
        }
        public override void LaunchMissile(AbstractTable table, int x, int y)
        {
            AbstractAttacker missile1 = new MissileAttack();
            AbstractAttacker missile2 = new MissileAttack();
            AbstractAttacker missile3 = new MissileAttack();
            table.AttackAt(x, y, missile1);
            table.RandomAttack(missile2);
            table.RandomAttack(missile3);
        }
    }
}