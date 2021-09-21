namespace Library
{
    public class Rooms : AbstractRooms
    {
        private static Rooms _instance; 
        public static Rooms Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Rooms();
                }
                return _instance;
            }
        }
        private Rooms()
        :base()
        {
        }
    }
}