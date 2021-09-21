using System.IO;

namespace Library
{
    public class TableOfCommandToString : AbstractCommandsTranslate
    {
        public TableOfCommandToString()
        :base(new AttackCommandToString())
        {
        }
        public override string Translate(string command, string lang)
        {
            if (command.ToLower() == "tableof")
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Commands.txt")[6];
            }
            else
            {
                return this.SendNext(command, lang);
            }
        }
    }
}