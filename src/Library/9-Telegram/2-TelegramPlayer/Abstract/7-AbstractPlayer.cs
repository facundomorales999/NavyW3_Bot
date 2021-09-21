namespace Library
{
    public abstract class AbstractPlayer : AbstractAttackablePlayer
    {
        public string Name {get; set; }
        public string Language {get; set; }
        protected AbstractPlayer(string name, long id, IPrinter clientP)
        :base(id, clientP)
        {
            this.Name = name;
            this.Language = "es-Es";
        }
    }
}