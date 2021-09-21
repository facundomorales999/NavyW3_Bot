using System.IO;

namespace Library
{
    public class ShowItemsCommandToString : AbstractCommandsTranslate
    {
        public ShowItemsCommandToString()
        :base(new MyTableCommandToString())
        {
        }
        public override string Translate(string command, string lang)
        {
            if (command.ToLower() == "showitems")
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Commands.txt")[7];
            }
            else
            {
                return this.SendNext(command, lang);
            }
        }
    }
}