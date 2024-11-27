

public class starPrints()
{
    public void star(int n)
    {
        Console.WriteLine("STAR PRINT ");        

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        starPrints sp = new starPrints();
        sp.star(5);
    }
}

