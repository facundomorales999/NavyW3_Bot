using System.Text;

namespace Library
{
    public class TableToEmoji : ITableToString
    {
        public string ToString(AbstractTable table)
        {
            AbstractFieldInterfaceToEmoji fieldToEmoji = new HeadFieldInterfacesToEmoji();
            StringBuilder toReturn = new StringBuilder();

            for (int j = 0; j < table.YLength(); j++)
            {
                for (int i = 0; i < table.XLength(); i++)
                {
                    toReturn.Append(fieldToEmoji.Convert(table.At(i, j)));
                }
                toReturn.Append("\n");
            }
            return toReturn.ToString();

        }
    }
}