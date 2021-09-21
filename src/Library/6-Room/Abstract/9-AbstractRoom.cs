namespace Library
{
    public abstract class AbstractRoom : AbstractRoomCommunicationManager
    {
        private AbstractPlayer _playing;
        protected AbstractRoom(AbstractPlayer host, int id)
        : base(host, id)
        {
            this._playing = null;
        }
        public void StartGame()
        {
            this.Start();
            this._playing = this.GetNext(null);
            this.NextStateAll();
        }
        public bool IsPlaying(AbstractPlayer maybePlaying)
        {
            return maybePlaying == this._playing;
        }
        public bool IsPlayingByName(string name)
        {
            return this._playing.Name.ToLower() == name.ToLower();
        }
        public string NextAttack()
        {
            this._playing = this.GetNext(this._playing);
            return this._playing.Name;
        }
        public string NextAttackWithNull()
        {
            this._playing = this.GetNext(null);
            return this._playing.Name;
        }
    }
}