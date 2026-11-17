namespace op11
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kies een optie");

            Console.WriteLine("1.menu 1\r\n2.menu 2\r\n3.programma sluit af\r\n");
            int keuze = int.Parse(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    Console.WriteLine("menu 1");
                    break;
                case 2:
                    Console.WriteLine("menu 2");
                    break;
                case 3:
                    Console.WriteLine("programma sluit af");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }
            Console.ReadLine(); 
        }
    }   
}
