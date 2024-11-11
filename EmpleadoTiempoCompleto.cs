using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEmpleados 
{
    internal class EmpleadoTiempoCompleto : Empleado
    {
        public double Bonificacion { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase + Bonificacion;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("Nombre del empleado: " + Nombre);
            Console.WriteLine("Salario: " + SalarioBase);
            Console.WriteLine("Bon ificacion que recibe " + Bonificacion);
            Console.WriteLine("Salario: " + CalcularSalario());
            Console.WriteLine("\n");

        }

    }
}
