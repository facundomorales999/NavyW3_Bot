using System.Text;

namespace Library
{
    public class TableToString : ITableToString
    {
        public string ToString(AbstractTable table)
        {
            AbstractFieldInterfaceToInt fieldToInt = new HeadFieldInterfacesToInt();
            StringBuilder toReturn = new StringBuilder();

            for (int j = 0; j < table.YLength(); j++)
            {
                for (int i = 0; i < table.XLength(); i++)
                {
                    toReturn.Append(fieldToInt.Convert(table.At(i, j)));
                }
                toReturn.Append("\n");
            }
            return toReturn.ToString();

        }
    }
}