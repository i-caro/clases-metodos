using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static int PosicionMenor(int[] array)
        {
            int posicionMenor = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[posicionMenor])
                {
                    posicionMenor = i;
                }
            }

            return posicionMenor;
        }

        static void Main(string[] args)
        {
            int[] numeros = { 34, 12, 24, 9, 56 };

            int posicion = PosicionMenor(numeros);

            Console.WriteLine($"La posición del número menor es: {posicion}");
            Console.WriteLine($"El número menor es: {numeros[posicion]}");
        }
    }
}
