using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEmpleados
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public double SalarioBase { get; set; }

        public virtual double CalcularSalario()
        {
            return SalarioBase; 
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nombre del empleado: " + Nombre);
            Console.WriteLine("Salario: " + SalarioBase);
            Console.WriteLine("Salario: " + CalcularSalario());
            Console.WriteLine("\n");

        }

    }
}
