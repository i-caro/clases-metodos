using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static int SumaDigitos(int numero)
        {
            int suma = 0;

            while (numero != 0)
            {
                suma += numero % 10;
                numero /= 10;
            }

            return suma;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número entero:");
            int numero = int.Parse(Console.ReadLine());

            int resultado = SumaDigitos(numero);

            Console.WriteLine($"La suma de los dígitos de {numero} es: {resultado}");
        }
    }
}
