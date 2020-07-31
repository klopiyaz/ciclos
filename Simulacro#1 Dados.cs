using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacro
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, dadoAd1 = 0, dadoAd2 = 2, total = 0;
            string continuar = "s";

            dado1 = aleatorio.Next(1, 7);
            dado2 = aleatorio.Next(1, 7);
            Console.Write("dado1 = " + dado1);
            Console.Write("   dado2 = " + dado2);
            total = dado1 + dado2;
            Console.Write("\nllevas = " + total);

            bool A = false;

            if (dado1 == 1 && dado2 == 1)
            {
                total = 0;
                Console.WriteLine("\n  (Eliminado)");
            }
            while (A != true && dado1 != 1 && dado2 != 1)
            {
                Console.WriteLine(" \nQuiere continuar? (s/n): ");
                continuar = Console.ReadLine();
                if (continuar == "s")
                {
                    dadoAd1 = aleatorio.Next(1, 7);
                    dadoAd2 = aleatorio.Next(1, 7);
                    Console.Write("dadoAd1 = " + dadoAd1);
                    Console.Write("   dadoAd2 = " + dadoAd2);
                    total = dadoAd1 +dadoAd2 + total;
                    Console.WriteLine("\n\nllevas = " + total);
                
                    if (dadoAd1 == 1 && dadoAd2 == 1)
                    {
                        total = 0;
                        Console.WriteLine("\n  (Eliminado)");
                    }
                    else if (total == 100 || total > 100)
                    {
                        total = + total;
                        Console.WriteLine(" (Ganas)");
                        continuar = "n";
                        A = true;
                    }
                }
                if (continuar == "n")
                {
                    Console.WriteLine("total = " + total);
                    A = true;
                }
            }
        }
    }
}
