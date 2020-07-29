using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, carta2 = 0, cartaAd = 0, total = 0;
            string otracarta = "s";
            int sumacartas = 0;

            carta = aleatorio.Next(1, 11);
            carta2 = aleatorio.Next(1, 11);
            Console.Write("Carta1 = " + carta);
            Console.Write("   Carta2 = " + carta2);
            total = carta + carta2;
            Console.Write("\nllevas = " + total);

            while (sumacartas < 21)
            {
                Console.WriteLine(" \nOtra carta? (s/n): ");
                otracarta = Console.ReadLine();
                if (otracarta == "s")
                {

                    cartaAd = aleatorio.Next(1, 11);
                    Console.WriteLine(" Carta Adicional = " + cartaAd);
                    total = cartaAd + total;
                    Console.WriteLine("llevas = " + total);

                    if (total > 21)
                    {
                        total = 0;
                        Console.WriteLine(" (Pierdes)");
                    }
                    else if (total == 21)
                    {
                        total = 21;
                        Console.WriteLine(" (Ganas)");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                if (otracarta == "n")
                {
                    Console.WriteLine("total = " + total);
                }
            }
        }
    }
}
