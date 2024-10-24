using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static int CalcularFactorial(int numero)
        {
            if (numero <= 1)
            {
                return 1;
            }
            else
            {
                return numero * CalcularFactorial(numero - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número para calcular su factorial:");
            int numero = int.Parse(Console.ReadLine());

            int factorial = CalcularFactorial(numero);

            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }
    }
}
