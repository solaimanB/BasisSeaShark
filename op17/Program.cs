namespace op17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namen = { "Alice", "Bob", "Charlie", "David", "Eve" };

            Console.WriteLine("Voer een getal in:");
            string invoer = Console.ReadLine();
            try
            {
                int waarde = int.Parse(invoer);
                for (int i = 0; i < waarde; i++)
                {
                    Console.WriteLine(namen[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Dat is geen geldig getal.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Dat getal is te groot of te klein.");
            }
            catch (Exception)
            {
                Console.WriteLine("Er ging iets anders mis.");
            }
            Console.ReadLine();
        }
    }
}
