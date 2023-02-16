using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Test();
            t1.list.Add(1);

            foreach (var item in t1.list) 
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadLine();
        }
    }

    public class Test
    {
        public List<int> list { get; set; }

        public Test()
        {
            list = new List<int>();
        }
    }
}
