using System;

namespace Library
{
    public class NullCommandToString : AbstractCommandsTranslate
    {
        public NullCommandToString()
        :base(null)
        {
        }
        public override string Translate(string command, string lang)
        {
            throw new NotImplementedException();
        }
    }
}