using System.IO;

namespace Library
{
    public class NewItemCommandToString : AbstractCommandsTranslate
    {
        public NewItemCommandToString()
        :base(new NextCommandToString())
        {

        }
        public override string Translate(string command, string lang)
        {
            if (command.ToLower() == "new")
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Commands.txt")[9];
            }
            else
            {
                return this.SendNext(command, lang);
            }
        }
    }
}