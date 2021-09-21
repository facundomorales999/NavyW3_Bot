using System.IO;

namespace Library
{
    public class AttackingMessageHandler : AbstractMessageHandler
    {
        public AttackingMessageHandler()
        :base(new NullMessageHandler())
        {
        }
        public override string[] MessagesOf(IPhase phase, string lang)
        {
            if (phase is AttackPhase)
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\6-Messages.txt");
            }
            else
            {
                return this.SendNext(phase, lang);
            }
        }
    }   
}