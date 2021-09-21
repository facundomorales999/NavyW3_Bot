namespace Library
{
    public class AntiaircraftMissileValidator : IItemValidator
    {
        public bool IsAddable(int position, AbstractItemSaver vesselToAdd, AbstractTable table)
        {
            foreach (IItem item in vesselToAdd.Items)
            {
                if (item is AntiaircraftMissile)
                {
                    throw new NoRepetitiveItemException();
                }
            }
            if (vesselToAdd.Items[position] != null)
            {
                throw new NoEmptyPositionException();
            }
            return true;
        }
    }
}
