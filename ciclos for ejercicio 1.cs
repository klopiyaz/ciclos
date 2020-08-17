using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {
        static void Main()
        {
            int n = 100;
            int x = 3;
            double E = 0;

            for (int i = 0; i < n; i++)
            {
                E += Math.Pow(x, i) / fact(i);
            }
            Console.WriteLine("E = " + E);
        }
        static double fact(double i)
        {
            if (i <= 1) return 1;
            return i * fact(i - 1);
        }
    }
}
