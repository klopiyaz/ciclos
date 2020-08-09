using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_de_clase_samana_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dadoAd = 0, dadoESP = 0,contadorespecial = 2,contadorperdidadevidas = 0, contadorganavidas = 0, total = 0, vidas = 3;
            string continuar = "s";
            string dadoespecial = "s";

            dado1 = aleatorio.Next(1, 7);
            Console.Write("dado1 = " + dado1);
            Console.Write("\nvidas = " + vidas);
            total = dado1;

            bool A = false;

            while (A != true) {
                Console.Write(" \n\nQuiere continuar? (s/n): ");
                continuar = Console.ReadLine();
                Console.Write("Usar dado especial? (s/n): ");
                dadoespecial = Console.ReadLine();
                if (continuar == "s")
                {
                    if (dadoespecial == "s")
                    {
                        dadoAd = 0;
                    }
                    if (dadoespecial == "n")
                    {
                        dadoAd = aleatorio.Next(1, 7);
                        Console.Write("\ndadoAd = " + dadoAd);
                        total += dadoAd;
                        Console.WriteLine("\nllevas = " + total);
                    }
                    if (dadoAd == 1 || dadoESP == 1)
                    {
                        contadorperdidadevidas++;
                        if (contadorperdidadevidas > 2)
                        {
                            contadorperdidadevidas = 1;
                        }
                    }
                    if ((dadoAd == 1 && contadorperdidadevidas == 2) || (dadoESP == 1 && contadorperdidadevidas == 2))
                    {
                        vidas -= 1;
                        Console.WriteLine("vidas = " + vidas);
                        if (vidas < 3)
                        {
                            total = total - 10;
                            Console.WriteLine("\n\nAcumulas = " + total);
                        }
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
                        if(dadoAd == 6)
                        {
                           contadorganavidas++;                       
                        }
                        else if (dadoAd == 6 && contadorganavidas == 2 && vidas < 3)
                        {
                           vidas++;
                           Console.WriteLine("vidas = " + vidas);
                        }
                        else
                        {
                        contadorganavidas = 0;
                        }
                        if (vidas > 3)
                        {
                            vidas = 3;
                        }
                }
                if (dadoespecial == "s")
                {
                    if (contadorespecial > 0)
                    {
                        contadorespecial -= 1;
                        dadoESP = aleatorio.Next(1, 13);
                        Console.Write("\ndadoESP = " + dadoESP);
                        Console.WriteLine("\nTe quedan = " + contadorespecial);
                        total = total + dadoESP;
                        Console.WriteLine("\nllevas = " + total);
                    }
                    else if (contadorespecial == 0)
                    {
                        dadoESP = 0;
                        Console.WriteLine("\nNo hay mas dados especiales");
                        contadorespecial = 0;
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
