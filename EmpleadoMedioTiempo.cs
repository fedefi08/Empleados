using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEmpleados
{
    internal class EmpleadoMedioTiempo : Empleado
    {
        public  int HorasTrabajadas { get; set; }


        public override double CalcularSalario()
        {
            Console.WriteLine("El empleado deberá cobrar lo siguiente: ");

            double ValorHora = SalarioBase / 8;  // Asegúrate de que SalarioBase esté accesible
            double PagoMedioTiempo = ValorHora * HorasTrabajadas;

            return PagoMedioTiempo;

        }

        public override void MostrarInfo()
        {
            Console.WriteLine("Nombre del empleado: " + Nombre);
            Console.WriteLine("Salario: " + SalarioBase);
            Console.WriteLine("El empleado trabajo: " + HorasTrabajadas);
            Console.WriteLine("Salario en base a las horas trabajadas: " + CalcularSalario());
            Console.WriteLine("\n");

        }



    }
}
