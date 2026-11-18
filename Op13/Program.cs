namespace Op13
{
    internal class Program
    {
        private static void Main()
        {
            int[] getallen = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int getal = 0;
                bool geldigeInvoer = false;
                while (!geldigeInvoer)
                {
                    Console.Write($"Voer getal {i + 1} in: ");
                    string invoerString = Console.ReadLine();
                    if (int.TryParse(invoerString, out getal))
                    {
                        geldigeInvoer = true;
                    }
                    else
                    {
                        Console.WriteLine("Ongeldige invoer. Probeer het opnieuw.");
                    }
                }
                getallen[i] = getal;
            }
            Console.WriteLine("\nDe ingevoerde getallen zijn:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Getal {i + 1}: {getallen[i]}");
            }
        }
    }
}