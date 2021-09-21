using System.IO;

namespace Library
{
    public class VolcanoToString : AbstractIEventToString
    {
        public VolcanoToString()
        :base(new NullIEventToString())
        {
        }
        public override string ToString(IEvent catastrophe, string lang)
        {
            if (catastrophe is Volcano)
            {
                return File.ReadAllLines(@"..\..\..\..\language"+lang+@"\Events.txt")[3];
            }
            else
            {
                return this.SendNext(catastrophe, lang);
            }
        }
    }
}