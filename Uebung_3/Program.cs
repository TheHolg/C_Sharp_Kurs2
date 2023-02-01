using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"c:\tmp\personen.csv";
            Person p1 = new Person(1, "Hans", "Hansen", 32);
            Person p2 = new Person(2, "Klaus", "Klausen", 21);
            Person p3 = new Person(3, "Maria", "Meier", 17);
            List<Person> personen = new List<Person> {p1, p2, p3};

            foreach (Person p in personen)
            {
                Console.WriteLine(p.datenAusgeben() + "\n");
            }

            //DateiExport(personen, pfad);
            //List<Person> gelesen = new List<Person>();
            //gelesen = DateiImport(pfad);

            //foreach (Person p in gelesen)
            //{
            //    Console.WriteLine(p.datenAusgeben() + "\n");
            //}

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

            Console.WriteLine("Datei erfolgreich geschrieben.");
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
                    Person tmp = new Person();
                    tmp.Id = int.Parse(spalten[0]);
                    tmp.Vorname = spalten[1];
                    tmp.Nachname = spalten[2];
                    tmp.Alter = int.Parse(spalten[3]);
                    personen.Add(tmp);
                }
                return personen;
            }
            else
            {
                Console.WriteLine("Datei nicht vorhanden!");
                return personen;
            }
        }
        
        class Person
        {
            public int Id { get; set; }
            public string Vorname { get; set; }
            public string Nachname { get; set; }
            public int Alter { get; set; }

            public Person() { }
            public Person(int Id, string Vorname, string Nachname, int Alter) 
            {
                this.Id = Id;
                this.Vorname = Vorname;
                this.Nachname = Nachname;
                this.Alter = Alter; 
            }
            public override string ToString()
            {
                return $"{Id};{Vorname};{Nachname};{Alter}\n";
            }
            public string datenAusgeben()
            {
                return $"ID:       {Id}\nVorame:   {Vorname}\nNachname: {Nachname}\nAlter:    {Alter}";
            }
        }
    }
}
