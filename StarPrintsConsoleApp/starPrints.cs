using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrintsConsoleApp
{
    public class starPrints()
    {
        public void star(int n)
        {
            Console.WriteLine("STAR PRINT ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* " + i);
                }
                Console.WriteLine();
            }
        }
    }
}
