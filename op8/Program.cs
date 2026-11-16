namespace op8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gelukswoord = "Lucky".ToUpper();  
            Console.WriteLine("Wat is me geluks woordje?");
            string? ingevoerdWoord = Console.ReadLine()?.ToUpper();
           
            if (ingevoerdWoord == gelukswoord)
            {
                Console.WriteLine("\n" + ingevoerdWoord + " is het juiste gelukswoord!");
            }
            else
            {
                Console.WriteLine("\nHelaas," + ingevoerdWoord + " dat is niet het juiste gelukswoord.");
            }
        }
    }
}
