using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dadoAd1 = 0, contador = 1, total = 0;
            string continuar = "s";

            bool A = false;

            dado1 = aleatorio.Next(1, 13);
            Console.Write("dado1 = " + dado1);
            total = dado1;
            Console.Write("\n\nllevas = " + total);

            while (A != true)
            {
                Console.Write(" \nQuiere continuar? (s/n): ");
                continuar = Console.ReadLine();
                if (continuar == "s")
                {
                    contador++;
                    dadoAd1 = aleatorio.Next(1, 13);
                    Console.Write("\ndadoAd1 = " + dadoAd1);
                    total = dadoAd1 + total;
                    Console.WriteLine("\n\nllevas = " + total);
                    if (contador >= 3)
                    {
                        if (dadoAd1 % 2 != 0)
                        {
                            total = 0;
                            Console.WriteLine("\n  (Eliminado)");
                            A = true;
                        }
                        else if (total >= 100)
                        {
                            total = +total;
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
                    Console.Write("\nTurno = " + contador);
                }
            }
        }
    }
}
