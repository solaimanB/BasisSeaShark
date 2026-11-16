namespace Invoer
{
    class Program
    {
        static void Main(string[] args)
        {
            string geboortejaar;
            Console.WriteLine("Wat is je geboortejaar?");
            geboortejaar = Console.ReadLine();

            int geboortejaarInt = int.Parse(geboortejaar);
            int leeftijd = 2026 - geboortejaarInt;
            Console.WriteLine("je bent " + leeftijd + "jaar oud!");
            
        }
    }
}