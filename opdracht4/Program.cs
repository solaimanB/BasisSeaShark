namespace opdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 7;

            if
                (getal >= 1 && getal <= 5)
            {
                Console.WriteLine("Het getal ligt binnen het bereik!");
            }
            else
            {
                Console.WriteLine("Het getal ligt buiten het bereik!");
            }   
        }
    }
}
