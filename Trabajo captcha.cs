using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_ciclos_anidados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int a = 0, b = 0, suma = 0, sumacorrecta = 0, oportunidades = 2;

            a = aleatorio.Next(0, 11);
            b = aleatorio.Next(0, 11);
            sumacorrecta = a + b;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.Write("\nLa Suma correcta es = ");
            suma = int.Parse(Console.ReadLine());

            while (suma != sumacorrecta)
            {
                if (oportunidades <= 0)
                {
                    Console.WriteLine(" Validacion incorrecta no puede continuar ");
                    break;
                }
                oportunidades -= 1;
                a = aleatorio.Next(0, 11);
                b = aleatorio.Next(0, 11);
                sumacorrecta = a + b;
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("\nSuma correcta = " + sumacorrecta);
                suma = int.Parse(Console.ReadLine());
            }
            if (suma == sumacorrecta)
            {
                Console.WriteLine("Puede continuar");
            }
        }
    }
}
