namespace op9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "small";

            Console.WriteLine("1.small\r\n2.medium\r\n3.large\r\n");
            int keuze = int.Parse(Console.ReadLine());
            string? invoer = Console.ReadLine();
            switch (keuze)
            {
                case 1:
                    Console.WriteLine("small: 2,00");
                    break;
                case 2:
                    Console.WriteLine("medium: 2,50");
                    break;
                case 3:
                    Console.WriteLine("large: 3,00");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }
            Console.ReadLine();
        }
    }
}
