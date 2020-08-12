using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, carta2 = 0, cartaAd = 0, total = 0, contador = 1, max = 0, sumacartas = 0; ;
            string otracarta = "s";

            Console.Write("Ingrese el numero de jugadores = ");
            int jugadores = int.Parse(Console.ReadLine());

            while (jugadores == 0 || jugadores > 5)
            {
                Console.WriteLine("No se puede jugar con ese numero de jugadores");
                Console.Write("Ingrese el numero de jugadores = ");
                jugadores = int.Parse(Console.ReadLine());
            }
            while (2 <= jugadores&&jugadores <= 5)
           { 
                Console.WriteLine("\nBienvenido jugador: " + contador);
                carta = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                Console.Write("\nCarta1 = " + carta);
                Console.Write("   Carta2 = " + carta2);
                total = carta + carta2;
                Console.Write("\nllevas = " + total);
                while (sumacartas < 21)
                {
                    Console.WriteLine(" \nOtra carta? (s/n): ");
                    otracarta = Console.ReadLine();
                    while (otracarta != "s" && otracarta != "n")
                    {
                        Console.WriteLine("Error, no se acepta otra respuesta");
                        Console.WriteLine(" \nOtra carta? (s/n): ");
                        otracarta = Console.ReadLine();
                    }
                    if (otracarta == "s")
                    {
                        cartaAd = aleatorio.Next(1, 11);
                        Console.WriteLine("\nCarta Adicional = " + cartaAd);
                        total = cartaAd + total;
                        Console.WriteLine("llevas = " + total);

                        if (total > 21)
                        {
                            Console.WriteLine(" (Pierdes)");
                            otracarta = "n";
                            total = 0;
                            break;
                        }
                        else if (total == 21)
                        {
                            total = 21;
                            Console.WriteLine(" (Ganas)");
                            otracarta = "n";
                            break;
                        }
                    }
                    if (otracarta == "n")
                    {
                        Console.WriteLine("total = " + total);
                        total = 0;
                        break;
                    }
                    if (total > max)
                    {
                        max = total;
                    }
                }
                contador++;
                if (contador > jugadores)
                {
                    break;
                }
            }
            Console.WriteLine("el ganador es = " + max);
        }
    }
}
