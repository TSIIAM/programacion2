using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaDominio;

namespace EmpresaWeb
{
    class Program
    {
        private static Empresa emp = new Empresa(12345664789102, "GruposN2AN2B");
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit) //mientras no seleccione la opcion 7
            {
                //muestro menú
                Console.WriteLine("Menu principal");
                Console.WriteLine("1-Alta Funcionario Contratado");
                Console.WriteLine("2-Alta Funcionario Presupuestado");
                Console.WriteLine("3-Listado de funcionario con Cargo");
                Console.WriteLine("4-Alta de categoria");
                Console.WriteLine("5-Aumento sueldo");
                Console.WriteLine("6-Listado de funcionarios con aumento");
                Console.WriteLine("7-Salir");

                Console.Write("Seleccione una opcion");
                int opcion = Convert.ToInt32(Console.ReadLine());//obtengo la opción seleccionada

                switch (opcion)//verifico la opción seleccionada para ver que método se invoca
                {
                    case 1:
                        altaFuncionarioContratado();
                        break;
                    case 2:
                        altaFuncionarioPresupuestado();
                        break;
                    case 3:
                        listadoFuncionariosXCargo();
                        break;
                   case 4:
                        altaCategoria();
                        break;
                    case 5:
                        aumentoSueldos();
                        break;
                    case 6:
                        listadoFuncionariosAumento();
                        break;
                    case 7:
                        salir();
                        exit = true;
                        break;
                }

            }

            Console.ReadKey();

        }

        private static void altaFuncionarioContratado()
        {
            Console.WriteLine("Alta Funcionario Contratado");
            Console.WriteLine("Ingrese nombre del funcionario");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo");
            double sueldo = 0;
            double.TryParse(Console.ReadLine(), out sueldo);
            Console.WriteLine("Ingrese fecha de nacimiento");
            DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese documento");
            string documento = Console.ReadLine();
            int numeroCarnetSalud = 0;
            Console.WriteLine("Ingrese número de carnet de salud");
            int.TryParse(Console.ReadLine(), out numeroCarnetSalud);
            Console.WriteLine(emp.mostrarCargos());
            Console.WriteLine("Ingrese el nombre del cargo");
            string nombreCargo = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de Contrato");
            DateTime fechaContrato = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese meses de duración");
            int mesesDuracionContrato = Convert.ToInt32(Console.ReadLine());
            if (emp.altaFuncionarioContratado(nombre, sueldo, fechaNacimiento, documento, numeroCarnetSalud, nombreCargo,
                fechaContrato, mesesDuracionContrato)) 
            {
                Console.WriteLine("El funcionario contratado se dió de alta correctamente");
            }
            else
            {
                Console.WriteLine("Los datos no son correctos");
            }

        }

        private static void altaFuncionarioPresupuestado()
        {
            Console.WriteLine("Alta Funcionario Contratado");
            Console.WriteLine("Ingrese nombre del funcionario");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo");
            double sueldo = 0;
            double.TryParse(Console.ReadLine(), out sueldo);
            Console.WriteLine("Ingrese fecha de nacimiento");
            DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese documento");
            string documento = Console.ReadLine();
            int numeroCarnetSalud = 0;
            Console.WriteLine("Ingrese número de carnet de salud");
            int.TryParse(Console.ReadLine(), out numeroCarnetSalud);
            Console.WriteLine(emp.mostrarCargos());
            Console.WriteLine("Ingrese el nombre del cargo");
            string nombreCargo = Console.ReadLine();
            Console.WriteLine("Ingrese anio de ingreso");
            int anioIngreso = Convert.ToInt32(Console.ReadLine());
            if (emp.altaFuncionarioPresupuestado(nombre, sueldo, fechaNacimiento, documento, numeroCarnetSalud, nombreCargo,
                anioIngreso))
            {
                Console.WriteLine("El funcionario presupuestado se dió de alta correctamente");
            }
            else
            {
                Console.WriteLine("Los datos no son correctos");
            }

        }
        public static void listadoFuncionariosXCargo()
        {
            Console.WriteLine(emp.mostrarCargos());
            Console.WriteLine("Ingrese nombre de cargo del cual se desean obtener los funcionarios");
            string nombreCargo = Console.ReadLine();
            string listado =  emp.listadoFuncionariosXCargo(nombreCargo);
            if (string.IsNullOrEmpty(listado))
            {
                Console.WriteLine("No existen funcionarios con el cargo especificado");
            }
            else
            {
                Console.WriteLine(listado);
            }
        }

        private static void altaCategoria()
        {
            Console.WriteLine("Alta de categoria");
            Console.WriteLine("Ingrese descripcion");
            string descripcion = Console.ReadLine();
            if (emp.altaCategoria(descripcion))
            {
                Console.WriteLine("La categoria se dio de alta en forma correcta");
            }
            else
            {
                Console.WriteLine("La descripcion ingresada ya existe");
            }
        }

        private static void listadoFuncionariosAumento()
        {
            Console.WriteLine(emp.listadoFuncionariosAumento());
        }

        private static void aumentoSueldos()
        {
            if (emp.aumentoSueldos())
            {
                Console.WriteLine("El aumento se realizo correctamente");
            }
               
        }
        private static void salir()
        {
            Console.Clear();

        }

    }
}
