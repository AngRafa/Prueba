using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hola Mundo
            //Console.WriteLine("Hola Mundo este es mi Primer Programa :D");
            //Console.ReadKey();


            //Hola Mundo con Nombre
            //string Nombre;

            //Console.WriteLine("Ingrea tu Nombre:");
            //Nombre = Console.ReadLine();

            //Console.WriteLine("Hola a todos soy " + Nombre);
            //Console.ReadKey();


            //Factorial
            //int numero, factorial = 1;

            //Console.WriteLine("Ingrese un número: ");
            //numero = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= numero; i++)
            //{
            //    factorial *= i;
            //}

            //Console.WriteLine("El factorial de: " + numero + " es: " + factorial);
            //Console.ReadKey();

            //Menu Operaciones Basicas
            int opcion;
            double numero1, numero2, resultado;

            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            numero2 = double.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine("El resultado de la Suma es: " + resultado);
                    Console.ReadKey();
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine("El resultado de la Resta es: " + resultado);
                    Console.ReadKey();
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine("El resultado de la Multiplicacion es: " + resultado);
                    Console.ReadKey();
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("El resultado de la Division es: " + resultado);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                        Console.ReadKey();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}