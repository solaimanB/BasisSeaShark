namespace Op12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namen = { "Solaiman", "Zekeriya", "Matin", "Hakan", "Ashraf" };
            for (int i = 0; i < namen.Length; i++)
            {
                Console.Write("voer naam" + (i + 1) + " in: ");
                namen[i] = Console.ReadLine();
                Console.WriteLine("De naam die u heeft ingevoerd is: ");
                foreach (string naam in namen)
                {
                    Console.WriteLine(naam);
                }
                Console.ReadLine();
            }
        }
    }
}   