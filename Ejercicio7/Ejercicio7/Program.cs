using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static bool EsMultiplo(int num1, int num2)
        {
            return num1 % num2 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número entero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número entero:");
            int num2 = int.Parse(Console.ReadLine());

            if (EsMultiplo(num1, num2))
            {
                Console.WriteLine($"{num1} es múltiplo de {num2}.");
            }
            else if (EsMultiplo(num2, num1))
            {
                Console.WriteLine($"{num2} es múltiplo de {num1}.");
            }
            else
            {
                Console.WriteLine($"{num1} y {num2} no son múltiplos entre sí.");
            }
        }
    }
}
