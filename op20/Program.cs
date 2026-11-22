namespace op20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> cijfers = new List<double>();
            string invoer = "";

            Console.WriteLine("Voer cijfers in 1.0 en 10.0, typ stop om te stoppen):");
            while (true)
            {
                Console.Write("Voer een cijfer in: ");
                invoer = Console.ReadLine();
                if (invoer == "stop")
                {
                    break;
                }
                if (double.TryParse(invoer, out double cijfer) && cijfer >= 1 && cijfer <= 10)
                {
                    cijfers.Add(cijfer);
                }
                else
                {
                    Console.WriteLine("Ongeldig cijfer probeer opnieuw.");
                }
            }
            if (cijfers.Count > 0)
            {
                double gemiddelde = cijfers.Average();
                Console.WriteLine($"Het gemiddelde van de ingevoerde cijfers is: {gemiddelde:F2}");
                Console.WriteLine("Hoogste cijfer: " + cijfers.Max());
                Console.WriteLine("Laagste cijfer: " + cijfers.Min());

                int aantalvoldoendes = cijfers.Where(c => c >= 5.5).Count();
                Console.WriteLine("Aantal voldoendes:(5,5 of hoger)  " + aantalvoldoendes);

                Console.WriteLine("\nAlle cijfers (van hoog naar laag):");
                var gesorteerd = cijfers.OrderByDescending(c => c);
                foreach (double c in gesorteerd)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("Er zijn geen geldige cijfers ingevoerd.");
            }
            Console.ReadLine();
        }
    }
}
