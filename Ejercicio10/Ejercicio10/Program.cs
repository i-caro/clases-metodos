using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Cliente
    {
        private string nombre;
        private double cantidadTotal;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            this.cantidadTotal = 0;
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                cantidadTotal += cantidad;
            }
            else
            {
                Console.WriteLine("La cantidad a ingresar debe ser positiva.");
            }
        }

        public void Sacar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= cantidadTotal)
            {
                cantidadTotal -= cantidad;
            }
            else if (cantidad > cantidadTotal)
            {
                Console.WriteLine($"No puedes sacar más dinero del que tienes en la cuenta ({cantidadTotal}).");
            }
            else
            {
                Console.WriteLine("La cantidad a sacar debe ser positiva.");
            }
        }

        public double GetCantidadTotal()
        {
            return cantidadTotal;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Cliente: {nombre}, Cantidad total en cuenta: {cantidadTotal}");
        }
    }

    class Banco
    {
        private Cliente cliente1;
        private Cliente cliente2;
        private Cliente cliente3;

        public Banco()
        {
            cliente1 = new Cliente("Juan");
            cliente2 = new Cliente("Ana");
            cliente3 = new Cliente("Pedro");
        }

        public void Operar()
        {
            cliente1.Ingresar(1000);
            cliente2.Ingresar(2000);
            cliente3.Ingresar(1500);
        }

        public void ObtenerEstado()
        {
            double totalBanco = cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal();
            Console.WriteLine($"Dinero total ingresado en el banco: {totalBanco}");

            cliente1.MostrarInformacion();
            cliente2.MostrarInformacion();
            cliente3.MostrarInformacion();
        }

        static void Main(string[] args)
        {

            Banco banco = new Banco();

            banco.Operar();

            banco.ObtenerEstado();
        }
    }
}
