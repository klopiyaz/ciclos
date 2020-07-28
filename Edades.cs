using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas personas participan (n) : ");
            string nombre;
            string respuesta = "s";
            double total = 0;
            int i = 0, max = 0, min = 199;
            int n = int.Parse(Console.ReadLine());
            string nombremax = "";
            string nombremin = "";

            while (respuesta == "s" && i < n)
            {
                Console.Write("\nCual es su nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese su Edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (edad > max)
                {
                    max = edad;
                    nombremax = nombre;
                }

                if (edad < min)
                {
                    min = edad;
                    nombremin = nombre;
                }
                total += edad;
                i++;
                Console.WriteLine("Desea ingresar otro dato (s o n): ");
                respuesta = Console.ReadLine();
            }
            double promedio = total / n;
            Console.WriteLine("\nPromedio: " + promedio);
            Console.WriteLine("max : " + max);
            Console.WriteLine("min : " + min);
            Console.WriteLine("nombre max : " + nombremax);
            Console.WriteLine("nombre min : " + nombremin);
        }

        }
    }
