namespace op19
{
    class Klant
    {
        private int id;
        private string naam;
        private string nummer;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public string Nummer
        {
            get { return nummer; }
            set { nummer = value; }
        }
        public Klant(int id, string naam, string nummer)
        {
            this.id = id;
            this.naam = naam;
            this.nummer = nummer;
        }
        public static List<Klant> Initialiseer()
        {
            List<Klant> lijst = new List<Klant>();
            lijst.Add(new Klant(1, "Marijke", "0612345678"));
            lijst.Add(new Klant(2, "Jan", "0612345677"));
            lijst.Add(new Klant(3, "Tim", "0612345666"));
            lijst.Add(new Klant(4, "Matt", "0612345555"));
            lijst.Add(new Klant(5, "Jeff", "0612344444"));
            return lijst;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Klant> klanten = Klant.Initialiseer();
            Console.WriteLine("1. Klanten gesorteerd op naam");
            var gesorteerdOpNaam = klanten.OrderBy(k => k.Naam);

            foreach (Klant klant in gesorteerdOpNaam)
            {
                Console.WriteLine($"{klant.Naam}: {klant.Nummer}");
            }

            Console.WriteLine("\n2. nummer begint met 0612345");
            var gefilterd = klanten.Where(k => k.Nummer.StartsWith("0612345"));
            foreach (Klant klant in gefilterd)
            {
                Console.WriteLine($"{klant.Naam}: {klant.Nummer}");
            }

            Console.WriteLine("\n3. Totaal aantal klanten");
            int totaalAantal = klanten.Count();

            Console.WriteLine("Totaal aantal klanten: " + totaalAantal);
            Console.WriteLine("\n4. Eerste klant in de gesorteerde lijst");

            Klant eersteKlant = gesorteerdOpNaam.First();
            Console.WriteLine("Eerste klant: " + eersteKlant.Naam);
            Console.ReadLine();
        }
    }
}