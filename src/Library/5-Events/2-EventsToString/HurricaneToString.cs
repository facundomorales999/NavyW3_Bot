using System.IO;

namespace Library
{
    public class HurricaneToString : AbstractIEventToString
    {
        public HurricaneToString()
        :base(new MeteorShowerToString())
        {
        }
        public override string ToString(IEvent catastrophe, string lang)
        {
            if (catastrophe is Hurricane)
            {
                return File.ReadAllLines(@"..\..\..\..\language"+lang+@"\Events.txt")[1];
            }   
            else
            {
                return this.SendNext(catastrophe, lang);
            }
        }
    }
}