using System.Collections.Generic;

namespace Library
{
    public abstract class AbstractRoomSaver : AbstractIdGetter
    {
        protected Dictionary<int, Room> _rooms;
        protected AbstractRoomSaver()
        {
            this._rooms = new Dictionary<int, Room>();
        }
        public int Count()
        {
            return this._rooms.Count;
        }
        public int AddSession(AbstractPlayer newPlayer)
        {
            int newId = AbstractIdGetter.Id;
            this._rooms.Add(newId, new Room(newPlayer, newId));
            return newId;
        }
        public void AddPlayer(AbstractPlayer newPlayer, int id)
        {
            this._rooms[id].AddPlayer(newPlayer);
        }
        protected Room GetRoomById(int id)
        {
            return this._rooms[id];
        }
        protected Room GetRoomByHost(AbstractPlayer maybeHost)
        {
            foreach (Room room in this._rooms.Values)
            {
                if (room.IsHost(maybeHost))
                {
                    return room;
                }
            }
            return null;
        }
        protected Room GetRoomByPlaying(AbstractPlayer maybePlaying)
        {
            foreach (Room room in this._rooms.Values)
            {
                if (room.IsPlaying(maybePlaying))
                {
                    return room;
                }
            }
            return null;
        }
        protected Room GetRoomByPlayingName(string player)
        {
            foreach (Room room in this._rooms.Values)
            {
                if (room.IsPlayingByName(player))
                {
                    return room;
                }
            }
            return null;
        }
        public bool IsHost(AbstractPlayer player)
        {
            return this.GetRoomByHost(player) != null;
        }
        public bool IsPlaying(AbstractPlayer player)
        {
            return this.GetRoomByPlaying(player) != null;
        }
        public bool IsPlayingWith(AbstractPlayer player, string partner)
        {
            AbstractRoom find = GetRoomByPlaying(player);
            if (find!=null && find.IsAPlayer(partner))
            {
                return true;
            }
            return false;
        }
    }
}