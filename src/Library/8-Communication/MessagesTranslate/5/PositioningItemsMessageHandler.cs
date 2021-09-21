using System.IO;

namespace Library
{
    public class PositioningItemsMessageHandler : AbstractMessageHandler
    {
        public PositioningItemsMessageHandler()
        :base(new AttackingMessageHandler())
        {
        }
        public override string[] MessagesOf(IPhase phase, string lang)
        {
            if (phase is PositioningItemsPhase)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\5-Messages.txt");
            }
            else
            {
                return this.SendNext(phase, lang);
            }
        }
    }   
}