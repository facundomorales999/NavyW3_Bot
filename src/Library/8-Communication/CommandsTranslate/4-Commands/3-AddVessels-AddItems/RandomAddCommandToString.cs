using System.IO;

namespace Library
{
    public class RandomAddCommandToString : AbstractCommandsTranslate
    {
        public RandomAddCommandToString()
        :base(new ShowItemsCommandToString())
        {
        }
        public override string Translate(string command, string lang)
        {
            if (command.ToLower() == "randomadd")
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Commands.txt")[10];
            }
            else
            {
                return this.SendNext(command, lang);
            }
        }
    }
}