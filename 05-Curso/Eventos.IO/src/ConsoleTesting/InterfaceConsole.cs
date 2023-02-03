using LOP.Eventos.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class InterfaceConsole
    {
        public static void Inicio(Message message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Inicio do Comando {message.MessageType}");
        }

        public static void Fim(Message message)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Fim do Comando {message.MessageType}");
            Console.WriteLine($"");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("************************");
            Console.WriteLine($"");

        }
    }
}
