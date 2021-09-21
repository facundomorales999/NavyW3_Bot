using System.IO;

namespace Library
{
    public class JoinCommandToString : AbstractCommandsTranslate
    {
        public JoinCommandToString()
        :base(new AddCommandToString())
        {
        }
        public override string Translate(string command, string lang)
        {
            if (command.ToLower() == "join")
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Commands.txt")[2];
            }
            else
            {
                return this.SendNext(command, lang);
            }
        }
    }
}