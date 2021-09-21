namespace Library
{
    public class KongValidator : IItemValidator
    {
        public bool IsAddable(int position, AbstractItemSaver vesselToAdd, AbstractTable table)
        {
            if (vesselToAdd.CountItem() != 0)
            {
                throw new NeededEmptyVesselException();
            }
            if (vesselToAdd.Length() < 4)
            {
                throw new TooShortVesselException();
            }
            return true;
        }
    }
}