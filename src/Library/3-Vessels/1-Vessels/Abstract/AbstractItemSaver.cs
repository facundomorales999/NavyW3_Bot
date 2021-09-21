using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class AbstractItemSaver : AbstractBlockerSaver
    {
        private IItem[] _items;
        public ReadOnlyCollection<IItem> Items
        {
            get
            {
                return Array.AsReadOnly<IItem>(this._items);
            }
        }
        public AbstractItemSaver(int size)
        {
            this._items = new IItem[size];
        }
        public int CountItem()
        {
            int i = 0;
            foreach (IItem item in this._items)
            {
                if (item != null)
                {
                    i++;
                }
            }
            return i;
        }
        public int Length()
        {
            return this._items.Length;
        }
        public bool IsAttackable(AbstractAttackable table, AbstractAttacker attack)
        {
            AbstractItemToAttackValidator validator = new HeadAttackValidator();
            bool avoidAttack = false;
            foreach (IItem item in this._items)
            {
                if (item != null)
                {
                    avoidAttack = validator.Validator(item).AvoidAttack(table, attack);
                    if (avoidAttack)
                    {
                        this.RemoveItem(item);
                        return !avoidAttack;
                    }
                }
            }
            return true;
        }
        public bool AddItem(int position, IItem toAdd, AbstractTable table, IItemValidator validator)
        {
            if (this.IsBlock())
            {
                throw new BlockedVesselException();
            }
            if (validator.IsAddable(position, this, table))
            {
                this._items[position] = toAdd;
                if (toAdd is IBlockItem)
                {
                    this.Block();
                }
                return true;
            }
            return false;
        }
        public void RemoveItem(IItem toRemove)
        {
            int index = Array.IndexOf(this._items, toRemove);
            if (index != -1)
            {
                if (this._items[index] is IBlockItem)
                {
                    this.Unblock();
                }
                this._items[index] = null;
            }
        }
    }
}