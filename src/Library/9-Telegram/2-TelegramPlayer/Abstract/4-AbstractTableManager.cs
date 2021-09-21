using System.Collections.ObjectModel;

namespace Library
{
    public abstract class AbstractTableManager : AbstractPlayerStateManager
    {
        protected Table _table;
        public AbstractTableManager(long id, IPrinter clientP)
        :base(id, clientP)
        {
            this._table = new Table();
        }
        public int XLength()
        {
            return this._table.XLength();
        }
        public int YLength()
        {
            return this._table.YLength();
        }
        public bool AddVessel(int x, int y, AbstractVessel vessel,bool ori)
        {
            return this._table.AddVessel(x,y,vessel,ori);
        }
        public ReadOnlyCollection<AbstractVessel> GetListOfVessels()
        {
            return this._table.GetListOfVessels();
        }
        public string VesselsEItemsToString(string lang)
        {
            ITableToStringInLang tableToList = new TableToList();
            return tableToList.ToString(this._table, lang);
        }
        public string ToEmojiTable()
        {
            ITableToString tableToEmoji = new TableToEmoji();
            return tableToEmoji.ToString(this._table);
        }
        public string ToEnemieEmojiTable()
        {
            ITableToString tableToEmoji = new EnemyTableToEmoji();
            return tableToEmoji.ToString(this._table);
        }
    }
}