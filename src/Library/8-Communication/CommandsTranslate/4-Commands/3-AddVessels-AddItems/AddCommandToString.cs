using System.IO;

namespace Library
{
    public class AddCommandToString : AbstractCommandsTranslate
    {
        public AddCommandToString()
        :base(new NewItemCommandToString())
        {
        }
        public override string Translate(string command, string lang)
        {
            if (command.ToLower() == "add")
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Commands.txt")[3];
            }
            else
            {
                return this.SendNext(command, lang);
            }
        }
    }
}