namespace Uebung_3
{
    internal partial class Program
    {
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
            public string DatenFormatiertAusgeben()
            {
                return $"ID:       {Id}\nVorame:   {Vorname}\nNachname: {Nachname}\nAlter:    {Alter}";
            }
        }
    }
}
