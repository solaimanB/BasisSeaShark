namespace op15
{
    internal class Program
    {
        public static int Optellen(int getal1, int getal2)
        {
            return getal1 + getal2;
        }

        static void Main()
        {
            int result = Program.Optellen(5, 10);
            Console.WriteLine($"De som is: {result}");
            Console.ReadKey();
        }        
    }
}
