using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        public static int[] CrearArray()
        {
            Console.WriteLine("Introduzca el tamaño del array a crear");
            int a = int.Parse(Console.ReadLine());
            int[] lista = new int[a];
            return lista;
        }

        public static double Media(int valor, int[] lista)
        {
            int b = lista.Length;
            return valor / b;
        }
        static void Main(string[] args)
        {
            int[] lista = CrearArray();
            int suma = 0;
            Console.WriteLine("Introduzca los valores para llenar este array");
            for (int i = 0; i < lista.Length; i++) { 
                int a = int.Parse(Console.ReadLine());
                lista[i] = a;
                suma = suma + a;
            }
            Console.WriteLine($"La suma de todos los valores es: {suma}");
            Console.WriteLine($"La media de los valores es: {Media(suma, lista)}");
        }
    }
}
