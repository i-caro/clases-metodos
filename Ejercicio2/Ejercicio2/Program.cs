using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        public static int ContarEspacios(string cadena)
        {
            int result = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                {
                    result++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una cadena y contaré los espacion en blanco.");
            string cadena = Console.ReadLine();
            int espacios = ContarEspacios(cadena);
            Console.WriteLine($"Esta cadena tiene {espacios} espacios.");
        }
    }
}
