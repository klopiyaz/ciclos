using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, dadoAd1 = 0, contador = 1, dadoAd2 = 0, sumadados = 0, porcentaje = 0, total = 0, contadorbonus = 0;
            string continuar = "s";

            bool A = false;

            dado1 = aleatorio.Next(1, 7);
            dado2 = aleatorio.Next(1, 7);
            Console.Write("dado1 = " + dado1);
            Console.Write("   dado2 = " + dado2);
            total = dado1 + dado2;
            Console.Write("\nllevas = " + total);


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
                    contador++;
                    dadoAd1 = aleatorio.Next(1, 7);
                    dadoAd2 = aleatorio.Next(1, 7);
                    Console.Write("dadoAd1 = " + dadoAd1);
                    Console.Write("   dadoAd2 = " + dadoAd2);
                    total = dadoAd1 + dadoAd2 + total;
                    Console.WriteLine("\n\nllevas = " + total);
                    if (dadoAd1 == 1 && dadoAd2 == 1)
                    {
                        total = 0;
                        Console.WriteLine("\n  (Eliminado)");
                        porcentaje = (sumadados * 100) / contador;
                        Console.WriteLine("\nPorcentaje = " + porcentaje);
                    }
                    else if (total >= 100)
                    {
                        total = +total;
                        Console.WriteLine(" (Ganas)");
                        continuar = "n";
                        A = true;
                        porcentaje = (sumadados * 100) / contador;
                        Console.WriteLine("\nPorcentaje = " + porcentaje);
                    }
                    if ((dado1 + dado2) > 6 || (dadoAd1 + dadoAd2) > 6)
                    {
                        sumadados++;
                    }
                    dado1 = 0;
                    dado2 = 0;
                    //para hacer que sean consecutivos
                    if (dado1 == dado2 || dadoAd1 == dadoAd2)
                    {
                        contadorbonus++;
                    }
                    if (contadorbonus == 3)
                    {
                        total = +total;
                        Console.WriteLine(" (Ganas)");
                        continuar = "n";
                        A = true;
                    }
                }
                if (continuar == "n")
                {
                    porcentaje = (sumadados * 100) / contador;
                    Console.WriteLine("\nPorcentaje = " + porcentaje);
                    Console.WriteLine("total = " + total);
                    A = true;
                }
                Console.Write("\nTurno = " + contador);
            }
        }
    }
}
