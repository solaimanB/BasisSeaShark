namespace opdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer = "42";//dit geeft een variable en geeft een nummer aan
            int getal = int.Parse(invoer);//zet tekts in getallen
            int resultaat = getal * 2;//verdubbeld het
            Console.WriteLine("Het dubbele is: " + resultaat);//laat zien het dubbele is en dan het resultaat van het verdubbelen
            Console.ReadLine();
        }
    }
}
