using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool prim = false;
            int primBroj = 0;

            for (int i = 1; i <= 100; i++)
            {

                for (int j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        prim = false;
                        break;
                    }
                }
                if (prim)
                {
                    primBroj++;
                }
                prim = true;

            }

            Console.WriteLine(primBroj);
            Console.ReadKey();
        }
    }
}
