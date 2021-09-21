namespace Library
{
    public class HeadMessageHandler : AbstractMessageHandler
    {
        public HeadMessageHandler()
        :base(new StartMessageHandler())
        {
        }
        public override string[] MessagesOf(IPhase phase, string lang)
        {
            return this.SendNext(phase, lang);
        }
    }   
}