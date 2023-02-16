using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uebung_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 0;

            while (true) 
            {
                Console.Clear();
                Console.SetCursorPosition(pos + 2,pos);
                Console.WriteLine("Comcave Sucks!");
                Thread.Sleep(50);
                pos++;
                if (pos > 28) 
                {
                    pos = 0;
                }
            }
        }
    }
}
