using System;

namespace Library
{
    public class NullIItemToString : AbstractIItemsToString
    {
        public NullIItemToString()
        :base(null)
        {
        }
        public override string ToString(IItem item, string lang)
        {
            throw new NotImplementedException();
        }
    }
}