public class Program
{

    public static void CalculeRacine(double number, int root)
    {
        if (number >= 1.00 && root >= 1)
        {
            double y = 0.00000001;
            double x = 1;
            double debut = 1;
            double Result = 0;
            while (x < number)
            {
                debut = debut + y;
                x = debut;
                for (int i = 0; i < root; i++)
                {
                    Result = x;
                    x = x * x;
                }
            }
            Console.WriteLine($"valleur approximative {Result}  ≈  {(int)Result}");

        }
        else
        {
            Console.WriteLine("Erreur Parametre");
        }

    }
    private static void Main(string[] args)
    {
        CalculeRacine(16, 4);
        CalculeRacine(9, 3);
        CalculeRacine(10, 2);
        CalculeRacine(8, 3);

    }
}