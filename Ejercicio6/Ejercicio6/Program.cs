using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static bool VerificarCredenciales(string usuario, string contrasena)
        {
            string usuarioCorrecto = "usuario2DAM";
            string contrasenaCorrecta = "pass2DAM";

            return usuario == usuarioCorrecto && contrasena == contrasenaCorrecta;
        }

        static void Main(string[] args)
        {
            int intentos = 3;

            while (intentos > 0)
            {
                Console.WriteLine("Introduce tu nombre de usuario:");
                string usuario = Console.ReadLine();

                Console.WriteLine("Introduce tu contraseña:");
                string contrasena = Console.ReadLine();

                if (VerificarCredenciales(usuario, contrasena))
                {
                    Console.WriteLine("¡Login exitoso!");
                    return;
                }
                else
                {
                    intentos--;
                    Console.WriteLine($"Login incorrecto. Te quedan {intentos} intentos.");
                }
            }

            Console.WriteLine("Has agotado todos los intentos. Acceso denegado.");
        }
    }
}
