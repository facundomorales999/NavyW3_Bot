namespace Library
{
    public abstract class AbstractRoomStart : AbstractRoomSaver
    {        
        public bool Start(AbstractPlayer maybeHost)
        {
            AbstractRoom toStart = this.GetRoomByHost(maybeHost);
            if (toStart == null)
            {
                throw new NoHostException();
            }
            if (toStart.Count()<=1)
            {
                throw new NoSinglePlayerException();
            }
            toStart.StartGame();
            return true;
        }
    }
}