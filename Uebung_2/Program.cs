using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder numberList = new StringBuilder();
            DateTime Time1 = DateTime.Now;

            for (int i = 0; i < 99999; i++) 
            {
                numberList.Append($"{i} ");
            }

            DateTime Time2 = DateTime.Now;
            TimeSpan ts = Time2 - Time1;

            Console.WriteLine(numberList + "\n");
            Console.WriteLine(ts.Milliseconds);
            Console.ReadLine();
        }
    }
}
