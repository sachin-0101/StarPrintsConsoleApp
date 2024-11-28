

using StarPrintsConsoleApp;
class Program
{
    public static void Main(string[] args)
    {
        starPrints sp = new starPrints();
        sp.star(5);

        Console.WriteLine("___________________________________");

        numberPrints nm = new numberPrints();
        nm.num();       
    }
}

