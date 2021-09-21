namespace Library
{
    public abstract class AbstractVesselAttacker : AbstractStateManager
    {
        protected AbstractVesselAttacker(int size, int health)
        : base(size, health)
        {
        }
        public virtual void LaunchMissile(AbstractTable table, int x, int y)
        {
            throw new NoOneMissileException();
        }

        public virtual void ThrowLoad(AbstractTable table, int x, int y)
        {
            throw new NoOneLoadException();
        }

        public virtual void LaunchMissile(AbstractTable table, int x1, int y1, int x2, int y2)
        {
            throw new NoTwoMissileException();
        }
        
    }
}