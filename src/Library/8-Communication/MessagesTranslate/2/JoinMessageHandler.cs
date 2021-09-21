using System.IO;

namespace Library
{
    public class JoinMessageHandler : AbstractMessageHandler
    {
        public JoinMessageHandler()
        :base(new StartGameMessageHandler())
        {
        }
        public override string[] MessagesOf(IPhase phase, string lang)
        {
            if (phase is WaitingForJoinPhase)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\2-Messages.txt");
            }
            else
            {
                return this.SendNext(phase, lang);
            }
        }
    }   
}