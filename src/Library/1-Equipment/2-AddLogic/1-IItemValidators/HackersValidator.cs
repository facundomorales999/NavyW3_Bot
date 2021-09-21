namespace Library
{
    public class HackersValidator : IItemValidator
    {
        public bool IsAddable(int position, AbstractItemSaver vesselToAdd, AbstractTable table)
        {
            if (!(vesselToAdd is Puntoon))
            {
                throw new WrongVesselException();
            }
            if (vesselToAdd.Items[position] != null)
            {
                throw new NoEmptyPositionException();
            }
            return true;
        }
    }
}