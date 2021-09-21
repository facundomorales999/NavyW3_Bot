namespace Library
{
    public abstract class AbstractVessel : AbstractVesselAttacker
    {
        protected AbstractVessel(int size, int health)
        : base(size, health)
        {
        }
    }
}