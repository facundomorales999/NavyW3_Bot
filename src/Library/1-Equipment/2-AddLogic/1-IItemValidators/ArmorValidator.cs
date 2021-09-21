namespace Library
{
    public class ArmorValidator : IItemValidator
    {
        public bool IsAddable(int position, AbstractItemSaver vesselToAdd, AbstractTable table)
        {
            if (vesselToAdd.Items[position] != null)
            {
                throw new NoEmptyPositionException();
            }

            return true;
        }
    }
}