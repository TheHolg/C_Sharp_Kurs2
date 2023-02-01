using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Blub ");
            changeTextColor(ConsoleColor.Yellow, "Test");
            Console.WriteLine(" Platsch");
            Console.ReadLine();
        }

        static void changeTextColor(ConsoleColor color, string text)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = originalColor;
        }
    }
}
