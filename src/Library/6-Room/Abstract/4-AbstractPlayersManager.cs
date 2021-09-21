using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public abstract class AbstractPlayersManager : AbstractRoomStateManager
    {
        protected List<AbstractPlayer> _players;
        public ReadOnlyCollection<AbstractPlayer> Players
        {
            get
            { 
                return this._players.AsReadOnly();
            }
        }
        protected AbstractPlayersManager(AbstractPlayer host, int id)
        : base(host, id)
        {
            this._players = new List<AbstractPlayer>();
            this.AddPlayer(host);
        }
        public void AddPlayer(AbstractPlayer newPlayer)
        {
            if (!this.IsStarted())
            {
                this._players.Add(newPlayer);
            }
        }
        public int Count()
        {
            return this._players.Count;
        }
        public bool IsAPlayer(string name)
        {
            return this.GetPlayer(name) != null;
        }
        protected AbstractPlayer GetPlayer(string maybeName)
        {
            foreach (AbstractPlayer player in this._players)
            {
                if(player.Name.ToLower().Equals(maybeName))
                {
                    return player;
                }
            }
            return null;
        }

    }
}