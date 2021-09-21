using System.IO;

namespace Library
{
    public class MeteorShowerToString : AbstractIEventToString
    {
        public MeteorShowerToString()
        :base(new VolcanoToString())
        {
        }
        public override string ToString(IEvent catastrophe, string lang)
        {
            if (catastrophe is MeteorShower)
            {
                return File.ReadAllLines(@"..\..\..\..\language"+lang+@"\Events.txt")[2];
            }
            else
            {
                return this.SendNext(catastrophe, lang);
            }
        }
    }
}