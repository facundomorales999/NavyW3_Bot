namespace Library
{
    public abstract class AbstractRoomsCommunication : AbstractAttackerRoom
    {        
        public void SendAllById(string message, int id)
        {
            this.GetRoomById(id).SendAll(message);
        }
        public void SendAllByHost(string message, AbstractPlayer host)
        {
            this.GetRoomByHost(host).SendAll(message);
        }
        public void SendAllByPlaying(AbstractPlayer player, string message)
        {
            this.GetRoomByPlaying(player).SendAll(message);
        }
        public void SendAllByPlayingName(string player, string message)
        {
            this.GetRoomByPlayingName(player).SendAll(message);
        }
        public void ShowTableOf(AbstractPlayer player, string name)
        {
            Room room = this.GetRoomByPlaying(player);
            room.SendAll(room.TableOfEnemies(name));
        }
    }
}