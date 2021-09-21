
using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            IReader telegram = new ClientTelegramReader();
            telegram.StartRead();
            
            Console.WriteLine("Se esperan los mensajes: ");
            Console.ReadKey();
            Console.ReadKey();

            telegram.StopRead();
        }
    }
}