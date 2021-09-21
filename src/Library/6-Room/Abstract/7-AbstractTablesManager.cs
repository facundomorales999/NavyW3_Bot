namespace Library
{
    public abstract class AbstractTablesManager : AbstractAttackManager
    {
        public AbstractTablesManager(AbstractPlayer host, int id)
        : base(host, id)
        {
        }
        public string TableOf(string name)
        {
            return this.GetPlayer(name).ToEmojiTable();
        }
        public string TableOfEnemies(string name)
        {
            return this.GetPlayer(name).ToEnemieEmojiTable();
        }
    }
}