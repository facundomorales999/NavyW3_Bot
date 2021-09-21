using System.IO;

namespace Library
{
    public class StartGameMessageHandler : AbstractMessageHandler
    {
        public StartGameMessageHandler()
        :base(new PositioningVesselsMessageHandler())
        {
        }
        public override string[] MessagesOf(IPhase phase, string lang)
        {
            if (phase is WaitingForStartGamePhase)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\3-Messages.txt");
            }
            else
            {
                return this.SendNext(phase, lang);
            }
        }
    }   
}