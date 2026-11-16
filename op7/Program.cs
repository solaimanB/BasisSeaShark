namespace op7
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Wat is me geluks getal?");
            ConsoleKeyInfo geluksgetal = Console.ReadKey();

            if (geluksgetal.Key == ConsoleKey.D7)
            {
                Console.WriteLine("\nJe hebt het juiste geluksgetal!");
            }
            else
            {
                Console.WriteLine("\nHelaas, dat is niet het juiste geluksgetal.");
            }

        }
    }
}
