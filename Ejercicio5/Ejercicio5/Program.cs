using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static double PotenciaIterativa(double baseNum, int exponente)
        {
            double resultado = 1;

            bool exponenteNegativo = exponente < 0;
            if (exponenteNegativo)
            {
                exponente = -exponente;
            }

            for (int i = 1; i <= exponente; i++)
            {
                resultado *= baseNum;
            }

            return exponenteNegativo ? 1 / resultado : resultado;
        }

        static double PotenciaRecursiva(double baseNum, int exponente)
        {
            if (exponente == 0)
            {
                return 1;
            }
            else if (exponente < 0)
            {
                return 1 / PotenciaRecursiva(baseNum, -exponente);
            }
            else
            {
                return baseNum * PotenciaRecursiva(baseNum, exponente - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la base:");
            double baseNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el exponente:");
            int exponente = int.Parse(Console.ReadLine());

            double resultadoIterativo = PotenciaIterativa(baseNum, exponente);
            Console.WriteLine($"Resultado iterativo: {baseNum}^{exponente} = {resultadoIterativo}");

            double resultadoRecursivo = PotenciaRecursiva(baseNum, exponente);
            Console.WriteLine($"Resultado recursivo: {baseNum}^{exponente} = {resultadoRecursivo}");
        }
    }
}
