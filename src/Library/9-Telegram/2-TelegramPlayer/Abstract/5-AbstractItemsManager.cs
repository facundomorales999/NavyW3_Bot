namespace Library
{
    public abstract class AbstractItemsManager : AbstractTableManager
    {
        public AbstractItemsManager(long id, IPrinter clientP)
        : base(id, clientP)
        {
        }
        public void AddItem(int position, IItem toAdd, AbstractVessel vessel)
        {
            AbstractItemToAddValidator validator = new HeadAddValidator();
            vessel.AddItem(position, toAdd, this._table, validator.Validator(toAdd));
        }
    }
}
