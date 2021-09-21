using System.Text;

namespace Library
{
    public class EnemyTableToEmoji : ITableToString
    {
        public string ToString(AbstractTable table)
        {
            AbstractFieldInterfaceToEmoji fieldToEmoji = new HeadFieldInterfacesToEmoji();
            StringBuilder toReturn = new StringBuilder();

            for (int j = 0; j < table.YLength(); j++)
            {
                for (int i = 0; i < table.XLength(); i++)
                {
                    if (table.At(i, j) is LiveHiddenVessel)
                    {
                        toReturn.Append(fieldToEmoji.Convert(new AttackableWater()));
                    }
                    else
                    {
                        toReturn.Append(fieldToEmoji.Convert(table.At(i, j)));
                    }
                }
                toReturn.Append("\n");
            }
            return toReturn.ToString();

        }
    }
}