using System;
using System.Collections.Generic;

namespace Library
{
    public class TelegramPlayers
    {
        private Dictionary<long, AbstractPlayer> _actualPlaying;
        private static TelegramPlayers _instance;
        public static TelegramPlayers Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TelegramPlayers();
                }
                return _instance;
            }
        }
        private TelegramPlayers()
        {
            this._actualPlaying = new Dictionary<long, AbstractPlayer> ();
        }
        public AbstractPlayer GetPlayer(string name, long id)
        {
            AbstractPlayer maybePlayer;
            try
            {
                maybePlayer = this._actualPlaying[id];
                maybePlayer.Name = name;
            } 
            catch (KeyNotFoundException)
            {
                maybePlayer = new Player(id, name, new ClientTelegramPrinter());
                this._actualPlaying.Add(id, maybePlayer);
            }
            return maybePlayer;
        }
    }
}