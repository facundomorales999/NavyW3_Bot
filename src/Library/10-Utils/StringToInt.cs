using System;
using System.Collections.Generic;

namespace Library
{
    public class StringToInt
    {
        public static int Convert(int from, int to, string toConvert,AbstractPlayer player, string intMeaning)
        {
            int converted = -1;
            try 
            {
                converted = Int32.Parse(toConvert);
                if (from <= converted && converted <= to)
                {
                    return converted;
                }
                else
                {
                    throw new OverflowException();
                }
            }
            catch(FormatException)
            {
                player.SendMessage(intMeaning + " debe ser un numero");
            }
            catch(OverflowException)
            {
                if (from != to)
                {
                    player.SendMessage(intMeaning + " debe ser un numero entre: " + from + " y " + to);
                }
                else
                {
                    player.SendMessage("Tu unica opcion disponible es: " + from);
                }
            }
            return -1;
        }
    }
}