namespace op16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double getal1 = 0;
            bool geldigGetal1 = false;

            while (!geldigGetal1)
            {
                Console.Write("Voer het eerste getal in: ");
                string input1 = Console.ReadLine();
                geldigGetal1 = double.TryParse(input1, out getal1);

                if (!geldigGetal1)
                {
                    Console.WriteLine("Ongeldige invoer. Probeer het opnieuw.");
                }
            }

            double getal2 = 0;
            bool geldigGetal2 = false;

            while (!geldigGetal2)
            {
                Console.Write("Voer het tweede getal in: ");
                string input2 = Console.ReadLine();
                geldigGetal2 = double.TryParse(input2, out getal2);

                if (!geldigGetal2)
                {
                    Console.WriteLine("Ongeldige invoer. Probeer het opnieuw.");
                }
            }

            Console.WriteLine("\nWat wil je doen?\n1 = optellen & aftrekken\n2 = optellen & vermenigvuldigen\n3 = optellen & delen");
            string keuze = Console.ReadLine();

            Console.WriteLine();

            switch (keuze)
            {
                case "1":
                    double som = Calculator.Optellen(getal1, getal2);
                    double verschil = Calculator.Aftrekken(getal1, getal2);
                    Console.WriteLine($"De som is: {som}");
                    Console.WriteLine($"Het verschil is: {verschil}");
                    break;
                case "2":
                    double som2 = Calculator.Optellen(getal1, getal2);
                    double product = Calculator.Vermenigvuldigen(getal1, getal2);
                    Console.WriteLine($"De som is: {som2}");
                    Console.WriteLine($"Het product is: {product}");
                    break;
                case "3":
                    double som3 = Calculator.Optellen(getal1, getal2);
                    try
                    {
                        double quotient = Calculator.Delen(getal1, getal2);
                        Console.WriteLine($"De som is: {som3}");
                        Console.WriteLine($"Het quotiënt is: {quotient}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze. Voer 1, 2 of 3 in");
                    break;
            }

            Console.WriteLine("\nDruk op een willekeurige toets om af te sluiten.");
            Console.ReadKey();
        }
    }
}
public class Calculator
{
    public static double Optellen(double getal1, double getal2)
    {
        return getal1 + getal2;
    }
    public static double Aftrekken(double getal1, double getal2)
    {
        return getal1 - getal2;
    }
    public static double Vermenigvuldigen(double getal1, double getal2)
    {
        return getal1 * getal2;
    }
    public static double Delen(double getal1, double getal2)
    {
        if (getal2 == 0)
        {
            throw new DivideByZeroException("Delen door nul is niet toegestaan.");
        }
        return getal1 / getal2;
    }
}