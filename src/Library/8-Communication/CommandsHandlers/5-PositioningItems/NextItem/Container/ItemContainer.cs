using System;
using System.Collections.Generic;

namespace Library
{
    public class ItemContainer 
    {
        private static ItemContainer _instance;
        public static ItemContainer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ItemContainer();
                }
                return _instance;
            }
        }

        private Dictionary<AbstractPlayer, (int,IItem)> _dict;
        private ItemContainer()
        {
            this._dict = new Dictionary<AbstractPlayer, (int,IItem)> ();
        }

        public (int, IItem) GetItem(AbstractPlayer player)
        {
            try
            {
                return this._dict[player];
            }
            catch(KeyNotFoundException)
            {
                Random rnd = new Random();
                AbstractNextItem nextItem = new HeadNextItem();
                this._dict.Add(player, (1, nextItem.NextItem(rnd.Next(0,5))));
            }
            return this._dict[player];
        }
        public int NewItem(AbstractPlayer player)
        {
            int newInt = this._dict[player].Item1 + 1;
            this._dict.Remove(player);
            Random rnd = new Random();
            AbstractNextItem nextItem = new HeadNextItem();
            this._dict.Add(player, (newInt, nextItem.NextItem(rnd.Next(0,5))));
            return this._dict[player].Item1;
        }
    }
}