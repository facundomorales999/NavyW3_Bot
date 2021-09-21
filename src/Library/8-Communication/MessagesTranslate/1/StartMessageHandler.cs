using System.IO;

namespace Library
{
    public class StartMessageHandler : AbstractMessageHandler
    {
        public StartMessageHandler()
        :base(new JoinMessageHandler())
        {
        }
        public override string[] MessagesOf(IPhase phase, string lang)
        {
            if (phase is WaitingForStartPhase)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\1-Messages.txt");
            }
            else
            {
                return this.SendNext(phase, lang);
            }
        }
    }   
}