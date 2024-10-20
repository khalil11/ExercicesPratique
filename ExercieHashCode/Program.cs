public class Program
{
    public class SameHashcode
    {
        public string Valeur;

        public SameHashcode(string valeur)
        {
            Valeur = valeur;
        }

        public override int GetHashCode()
        {
            return 50;

        }

        public override bool Equals(object obj)
        {
            //Good practice lors de l'override de la methode GetHashCode() il faut aussi le faire Equals
            //Code ...
            return true;

        }
    }
    private static void Main(string[] args)
    {
        SameHashcode A = new SameHashcode("Hola");
        SameHashcode B = new SameHashcode("Salut");
        SameHashcode C = new SameHashcode("Hello");

        Console.WriteLine(A.Valeur + " HashCode " + A.GetHashCode());
        Console.WriteLine(B.Valeur + " HashCode " + B.GetHashCode());
        Console.WriteLine(C.Valeur + " HashCode " + C.GetHashCode());


    }
}