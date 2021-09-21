using System.IO;

namespace Library
{
    public class StartCommandsToString : AbstractCommandsTranslate
    {
        public StartCommandsToString()
        :base(new CreateCommandToString())
        {
        }
        public override string Translate(string command, string lang)
        {
            if (command.ToLower() == "start")
            {
                return File.ReadAllLines(@"..\..\language\"+lang+@"\Commands.txt")[0];
            }
            else
            {
                return this.SendNext(command, lang);
            }
        }
    }
}