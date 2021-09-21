using System.IO;

namespace Library
{
    public class PositioningVesselsMessageHandler : AbstractMessageHandler
    {
        public PositioningVesselsMessageHandler()
        :base(new PositioningItemsMessageHandler())
        {
        }
        public override string[] MessagesOf(IPhase phase, string lang)
        {
            if (phase is PositioningVesselsPhase)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\4-Messages.txt");
            }
            else
            {
                return this.SendNext(phase, lang);
            }
        }
    }   
}