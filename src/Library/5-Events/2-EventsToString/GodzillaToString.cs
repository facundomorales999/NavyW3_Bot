using System.IO;

namespace Library
{
    public class GodzillaToString : AbstractIEventToString
    {
        public GodzillaToString()
        :base(new HurricaneToString())
        {
        }
        public override string ToString(IEvent catastrophe, string lang)
        {
            if (catastrophe is Godzilla)
            {
                return File.ReadAllLines(@"..\..\..\..\language"+lang+@"\Events.txt")[0];
            }
            else
            {
                return this.SendNext(catastrophe, lang);
            }
        }
    }
}