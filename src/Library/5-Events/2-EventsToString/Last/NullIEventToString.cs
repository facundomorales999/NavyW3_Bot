using System;

namespace Library
{
    public class NullIEventToString : AbstractIEventToString
    {
        public NullIEventToString()
        :base(null)
        {
        }
        public override string ToString(IEvent catastrophe, string lang)
        {
            throw new NotImplementedException();
        }
    }
}