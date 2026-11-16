namespace op5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double breedte = 23.45;
            Console.WriteLine("Breedte: {0}", breedte);

            double lengte = 30.34;
            Console.WriteLine("Lengte: {0}", lengte);

            double oppervlakte = breedte * lengte;
            Console.WriteLine("De oppervlakte is: {0}", oppervlakte);

            Console.ReadLine();
        }
    }
}
