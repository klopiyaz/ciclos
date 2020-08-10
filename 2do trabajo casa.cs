using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_trabajo_en_casa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dadoAd = 0, dadocadatresturno1 = 0, dadocadatresturno2 = 0, contadordadoscadatresturnos = 1, contadorperdidadevidas = 1, total = 0, vidas = 3;
            string continuar = "s";

            dado1 = aleatorio.Next(1, 7);
            Console.Write("dado1 = " + dado1);
            Console.Write("\nvidas = " + vidas);
            total = dado1;

            bool A = false;

            while( A != true)
            {
                Console.Write(" \n\nQuiere continuar? (s/n): ");
                continuar = Console.ReadLine();
                if(continuar == "s")
                {
                    contadorperdidadevidas++;
                    contadordadoscadatresturnos++;
                    dadoAd = aleatorio.Next(1, 7);
                    Console.WriteLine("\ndadoAd = " + dadoAd);
                    total += dadoAd;
                    Console.WriteLine("\nllevas = " + total);
                    if (contadorperdidadevidas == 2)
                    {
                        vidas -= 1;
                        Console.WriteLine("vidas = " + vidas);
                        contadorperdidadevidas = 0;
                    }
                    if (vidas == 0)
                    {
                        vidas = 0;
                        Console.WriteLine("\n (Eliminado)");
                        A = true;
                    }
                    else if (total >= 100)
                    {
                        total = +total;
                        Console.WriteLine("\n (Ganas)");
                        A = true;
                    }
                    if (contadordadoscadatresturnos == 3)
                    {
                        dadocadatresturno1 = aleatorio.Next(1, 7);
                        dadocadatresturno2 = aleatorio.Next(1, 7);
                        Console.WriteLine("\nDado por 3 turnos = " + dadocadatresturno1+"    Dado por 3 turnos = " + dadocadatresturno2);
                        total = total + dadocadatresturno1 + dadocadatresturno2;
                        Console.WriteLine("\nllevas = " + total);
                        if (dadocadatresturno1 == dadocadatresturno2)
                        {
                            vidas++;
                            Console.WriteLine("vidas = " + vidas);
                            contadordadoscadatresturnos = 0;
                            if (vidas > 3)
                            {
                                vidas = 3;
                            }
                        }
                    }
                }
                if (continuar == "n")
                {
                    Console.WriteLine("\nAcumulado = " + total);
                    A = true;
                }
            }
        }
    }
}
