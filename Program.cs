using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio 2: Sistema de Empleados
              Crea una clase base Empleado con propiedades Nombre(string) y SalarioBase(double).

              Crea clases derivadas EmpleadoTiempoCompleto y EmpleadoMedioTiempo.

              EmpleadoTiempoCompleto debe tener una propiedad Bonificacion(doble).

              EmpleadoMedioTiempo debe tener una propiedad HorasTrabajadas(int).

              En la clase Empleado, crea un métodoCalcularSalario para recuperar el salario.

              Sobrescribe CalcularSalarioen las clases derivadas para incluir la compensación en EmpleadoTiempoCompletoy 
              calcular el salario en función de las horas trabajadas enEmpleadoMedioTiempo.
              Crea una lista de empleados y muestra el salario de cada empleado usando polimorfismo.

             */

            int horasTrabajadas, EmpleadosOpciones;
            Empleado empleado = new Empleado();

            Console.WriteLine("Seleccione empleados segun tiempo de trabajo");
            Console.WriteLine("1)Empleado tiempo completo");
            Console.WriteLine("2)Empleado medio tiempo");
            Console.WriteLine("3)Salir");
            Console.WriteLine("Opcion:");
            EmpleadosOpciones = int.Parse(Console.ReadLine());

            switch (EmpleadosOpciones)
            {
                case 1:
                    //Trabajo 8 horas o mas

                    int CantidadEmpleados;
                    Console.WriteLine("Ingrese la cantidad de empleados a cargar: ");
                    CantidadEmpleados = int.Parse(Console.ReadLine());

                    List<EmpleadoTiempoCompleto>listaEmpTiempoC = new List<EmpleadoTiempoCompleto>();

                    for (int i = 0; i < CantidadEmpleados; i++)
                    {
                        EmpleadoTiempoCompleto empTiempoC = new EmpleadoTiempoCompleto();

                        Console.WriteLine("Ingrese el nombre del empleado: ");
                        empTiempoC.Nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el salario base del empleado: ");
                        empTiempoC.SalarioBase = double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la bonificación del empleado: ");
                        empTiempoC.Bonificacion = double.Parse(Console.ReadLine());

                        //Calculo
                        double salarioTotal = empTiempoC.CalcularSalario();
                        Console.WriteLine(empTiempoC.CalcularSalario());

                        listaEmpTiempoC.Add(empTiempoC);

                    }

                    Console.WriteLine("\n");
                    Console.WriteLine("Listado de personas que trabajaron 8 horas");
                    foreach (var TiempoC in listaEmpTiempoC)
                    {
                        TiempoC.MostrarInfo();
                    }

                    break;
                case 2:

                    int CantidadEmpleadosMedioTiempo;
                    Console.WriteLine("Ingrese la cantidad de empleados a cargar que trabaron medio tiempo: ");
                    CantidadEmpleadosMedioTiempo = int.Parse(Console.ReadLine());

                    List<EmpleadoMedioTiempo> ListaEmpleadoMedioTiempo = new List<EmpleadoMedioTiempo>();

                    for (int x = 0; x < CantidadEmpleadosMedioTiempo; x++)
                    {
                        EmpleadoMedioTiempo EmpMedioT = new EmpleadoMedioTiempo();

                        Console.WriteLine("Ingrese el nombre del empleado: ");
                        EmpMedioT.Nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el salario base del empleado: ");
                        EmpMedioT.SalarioBase = double.Parse(Console.ReadLine());

                        Console.WriteLine("El empleado trabajo: ");
                        EmpMedioT.HorasTrabajadas = int.Parse(Console.ReadLine());

                        //Calculo
                        //double salarioTotalMedioTiempo = EmpMedioT.CalcularSalario();
                        Console.WriteLine(EmpMedioT.CalcularSalario());

                        ListaEmpleadoMedioTiempo.Add(EmpMedioT);
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine("Listado de personas que trabajaron medio tiempo");
                    foreach (var MedioT in ListaEmpleadoMedioTiempo)
                    {
                        MedioT.MostrarInfo();
                    }


                    break;
                case 3:
                    Console.WriteLine("FIN DEL PROGRAMA");
                break;
            }
            Console.ReadKey();



        }

    }
}
