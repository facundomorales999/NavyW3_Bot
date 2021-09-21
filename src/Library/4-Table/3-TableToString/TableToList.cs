using System.Text;

namespace Library
{
    public class TableToList : ITableToStringInLang
    {
        public string ToString(AbstractTable table, string lang)
        {
            AbstractVesselsToString vesselsName = new HeadVesselsToString();
            AbstractIItemsToString itemsName = new HeadIItemsToString();

            StringBuilder toReturn = new StringBuilder();
            int vesselInt = 1;
            int itemInt = 1;

            foreach (AbstractVessel vessel in table.GetListOfVessels())
            {
                toReturn.Append(vesselInt + " ");
                toReturn.Append(vesselsName.ToString(vessel, lang) + "\n");
                foreach (IItem item in vessel.Items)
                {
                    if (item != null)
                    {
                        toReturn.Append("    " + itemInt);
                        toReturn.Append(itemsName.ToString(item, lang) + "\n");
                    }
                    itemInt++;
                }
                itemInt = 1;
                vesselInt++;
            }

            return toReturn.ToString();

        }
    }
}