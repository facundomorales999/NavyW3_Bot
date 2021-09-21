namespace Library
{
    public class SateliteLockValidator : IItemValidator
    {
        public bool IsAddable(int position, AbstractItemSaver vesselToAdd, AbstractTable table)
        {
            foreach (AbstractVessel vassel in table.GetListOfVessels())
            {
                foreach (IItem item in vassel.Items)
                {
                    if (item is SateliteLock)
                    {
                        throw new NoRepetitiveItemException();
                    }
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