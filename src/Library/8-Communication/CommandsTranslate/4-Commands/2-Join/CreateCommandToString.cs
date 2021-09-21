using System.IO;

namespace Library
{
    public class CreateCommandToString : AbstractCommandsTranslate
    {
        public CreateCommandToString()
        :base(new JoinCommandToString())
        {
        }
        public override string Translate(string command, string lang)
        {
            if (command.ToLower() == "create")
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Commands.txt")[1];
            }
            else
            {
                return this.SendNext(command, lang);
            }
        }
    }
}