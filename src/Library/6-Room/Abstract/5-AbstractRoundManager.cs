using System;

namespace Library
{
    public abstract class AbstractRoundManager : AbstractPlayersManager
    {
        public AbstractRoundManager(AbstractPlayer host, int id)
        : base(host, id)
        {
        }
        protected AbstractPlayer GetNext(AbstractPlayer player)
        {
            if (player == null)
            {
                return this._players[0];
            }

            int nextPlayer = this._players.IndexOf(player) + 1;

            if (nextPlayer != (nextPlayer % this._players.Count))
            {
                Console.WriteLine("Se lanzo la excepcion.");
                throw new EndPhaseException();
            }

            return this._players[nextPlayer];
        }
        public void NextStateAll()
        {
            foreach (AbstractPlayer player in this._players)
            {
                player.NextState();
            }
        }
    }
}