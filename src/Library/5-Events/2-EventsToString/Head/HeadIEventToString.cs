namespace Library
{
    public class HeadIEventToString : AbstractIEventToString
    {
        public HeadIEventToString()
        :base(new GodzillaToString())
        {
        }
        public override string ToString(IEvent catastrophe, string lang)
        {
            return this.SendNext(catastrophe, lang);
        }
    }
}