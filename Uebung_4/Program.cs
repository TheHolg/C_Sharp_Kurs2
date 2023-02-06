using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Uebung_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> karten = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,27,28,29,30,31,32};

            //karten = MischeKarten(karten);
            karten = DeckAbheben(karten);

            foreach (int i in karten)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }

        static List<int> MischeKarten(List<int> karten)
        {
            List<int> tmp = new List<int>();
            Random rnd = new Random();
            int index;

            for (int i = 0; i < 5; i++)
            {
                int max = karten.Count;

                for (int j = 0; j < max; j++)
                {
                    index = rnd.Next(0, karten.Count);
                    tmp.Add(karten[index]);
                    karten.Remove(karten[index]);
                }

                karten = tmp;
            }

            return karten;
        }

        static List<int> DeckAbheben(List<int> karten) 
        {
            Random rnd = new Random();
            int menge = rnd.Next(4, karten.Count/3);
            int i = 0;
            
            while(i < menge)
            {
                karten.Add(karten[0]);
                karten.RemoveAt(0);
                i++;
            }
            
            return karten;
        }
    }
}
