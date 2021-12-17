using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_mhetodes
{
   public class ConsoleHeleper
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void PrintMessage(string label, string message)
        {
            Console.WriteLine($"{label} {message}");
        }
        public static void PrintMessage(string message,  int count )
        {

        }
    }
}
