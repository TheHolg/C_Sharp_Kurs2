using System;
using System.Collections.Generic;
using System.IO;


namespace Uebung_3
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"c:\tmp\personen.csv";
            Person p1 = new Person(1, "Hans", "Hansen", 32);
            Person p2 = new Person(2, "Klaus", "Klausen", 21);
            Person p3 = new Person(3, "Maria", "Meier", 17);
            List<Person> personen = new List<Person> {p1, p2, p3};

            ListeAusgeben(personen);
            DateiExport(personen, pfad);

            Console.WriteLine("<Enter> drücken um die geschriebene Datei einzulesen und auszugeben.");
            Console.ReadLine();

            personen = DateiImport(pfad);
            ListeAusgeben(personen);

            Console.WriteLine("<Enter> drücken um das Programm zu beenden.");
            Console.ReadLine();
        }

        static void DateiExport(List<Person> personen, string pfad)
        {
            if (File.Exists(pfad))
            {
                File.Delete(pfad);
            }
            
            foreach (Person person in personen)
            {
                File.AppendAllText(pfad, person.ToString());
            }

            Console.WriteLine("Datei erfolgreich geschrieben.\n");
        }
        static List<Person> DateiImport(string pfad)
        {
            List<Person> personen = new List<Person>();

            if (File.Exists(pfad))
            {
                string[] zeilen = File.ReadAllLines(pfad);

                foreach (string zeile in zeilen)
                {
                    string[] spalten = zeile.Split(';');
                    personen.Add(new Person(int.Parse(spalten[0]), spalten[1], spalten[2], int.Parse(spalten[3])));
                }

                Console.WriteLine("Datei erfolgreich gelesen.\n");

                return personen;
            }
            else
            {
                Console.WriteLine("Datei nicht vorhanden!");
                return personen;
            }
        }
        static void ListeAusgeben(List<Person> personen)
        {
            foreach (Person p in personen)
            {
                Console.WriteLine(p.DatenFormatiertAusgeben() + "\n");
            }
        }
    }
}
