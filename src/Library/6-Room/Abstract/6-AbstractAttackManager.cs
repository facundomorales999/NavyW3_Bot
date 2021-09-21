namespace Library
{
    public abstract class AbstractAttackManager : AbstractRoundManager
    {
        public AbstractAttackManager(AbstractPlayer host, int id)
        : base(host, id)
        {
        }
        public void AttackWithOneMissile(AbstractPlayer playing, string name, int vessel, int x, int y)
        {
            this.GetPlayer(name).ReciveOneMissile(playing.GetListOfVessels()[vessel], x, y);
        }
        public void AttackWithTwoMissile(AbstractPlayer playing, string name, int vessel, int x1, int y1, int x2, int y2)
        {
            this.GetPlayer(name).ReciveTwoMissile(playing.GetListOfVessels()[vessel], x1, y1, x2, y2);
        }
        public void AttackWithLoad(AbstractPlayer playing, string name, int vessel, int x, int y)
        {
            this.GetPlayer(name).ReciveLoad(playing.GetListOfVessels()[vessel], x, y);
        }
    }
}