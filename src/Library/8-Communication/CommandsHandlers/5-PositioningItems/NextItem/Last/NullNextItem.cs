using System;

namespace Library
{
    public class NullNextItem : AbstractNextItem
    {
        public NullNextItem()
        :base(null)
        {
        }
        public override IItem NextItem(int random)
        {
            throw new NotImplementedException();
        }
    }
}