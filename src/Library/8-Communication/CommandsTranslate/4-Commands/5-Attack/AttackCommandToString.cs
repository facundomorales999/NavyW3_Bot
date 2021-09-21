using System.IO;

namespace Library
{
    public class AttackCommandToString : AbstractCommandsTranslate
    {
        public AttackCommandToString()
        :base(new NullCommandToString())
        {
        }
        public override string Translate(string command, string lang)
        {
            if (command.ToLower() == "attack")
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Commands.txt")[8];
            }
            else
            {
                return this.SendNext(command, lang);
            }
        }
    }
}