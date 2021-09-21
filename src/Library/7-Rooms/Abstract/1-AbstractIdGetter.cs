namespace Library
{
    public abstract class AbstractIdGetter
    {
        private static int _id = 0;
        public static int Id 
        { 
            get 
            { 
                _id ++;
                return _id;
            }
            private set {}
        }
    }
}