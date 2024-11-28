using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrintsConsoleApp
{
        public class numberPrints()
        {
            public void num()
            {
                Console.WriteLine("NUMBER PRINT ");

                for (int row = 8; row >= 1; --row)
                {
                    for (int col = 1; col <= row; ++col)
                    {
                        Console.Write("*" + col);
                    }

                    Console.WriteLine();
                }
            }
        }
   
}
