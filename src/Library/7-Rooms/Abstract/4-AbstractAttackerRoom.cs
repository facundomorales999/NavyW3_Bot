namespace Library
{
    public abstract class AbstractAttackerRoom : AbstractRoomStart
    {        
        public string NextAttackByPlaying(AbstractPlayer player)
        {
            return this.GetRoomByPlaying(player).NextAttack();
        }
        public string NextAttackNullByPlaying(AbstractPlayer player)
        {
            return this.GetRoomByPlaying(player).NextAttackWithNull();
        }
        public void AttackWithOneMissile(AbstractPlayer player, string name, int vessel, int x, int y)
        {
            this.GetRoomByPlaying(player).AttackWithOneMissile(player, name, vessel, x, y);
        }
        public void AttackWithTwoMissile(AbstractPlayer player, string name, int vessel, int x1, int y1, int x2, int y2)
        {
            this.GetRoomByPlaying(player).AttackWithTwoMissile(player, name, vessel, x1, y1, x2, y2);
        }
        public void AttackWithLoad(AbstractPlayer player, string name, int vessel, int x, int y)
        {
            this.GetRoomByPlaying(player).AttackWithLoad(player, name, vessel, x, y);
        }
        public void AttackPhase(AbstractPlayer player)
        {
            AbstractEndPhase endPhase = new HeadEndPhase();
            endPhase.DoEndPhase(this.GetRoomByPlaying(player).Players);
        }
    }
}