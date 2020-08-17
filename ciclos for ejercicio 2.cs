using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.25;
            double sinx = 0;
            int n = 100;

            for (int i = 0; i <= n; i++)
            {
                sinx += ((Math.Pow((-1), i)) / fact((2*i)+1))* Math.Pow(x,((2*i)+1));
            }
            Console.WriteLine("sin = " + sinx);
        }
        static double fact(double i)
        {
            if (i <= 1) return 1;
            return i * fact(i - 1);
        }
    }
}
