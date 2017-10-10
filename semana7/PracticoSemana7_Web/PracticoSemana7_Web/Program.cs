using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticoSemana7_Dominio;

namespace PracticoSemana7_Web
{
    class Program
    {
        private static Empresa emp = new Empresa();
        static void Main(string[] args)
        {
            MostrarMenu();
            Console.ReadKey();
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Bienvenido al menu principal");
            Console.WriteLine("1-Alta Cliente");
            Console.WriteLine("2-Alta Tarea");
            Console.WriteLine("3-Alta Proyecto");
            Console.WriteLine("4-Agregar Tareas a Proyecto");
            Console.WriteLine("5-Mostrar Tareas de un Proyecto");
            Console.WriteLine("6-Mostrar Duracion de un Proyecto");
            Console.WriteLine("7-Mostrar proyectos de un Cliente");
            Console.WriteLine("8-Listar Clientes");
            Console.WriteLine("9-Listar Proyectos");
            Console.WriteLine("-Salir");
            Console.Write("Seleccione una opcion :  ");

            int opcion = 0;
            int.TryParse(Console.ReadLine(), out opcion);
            Console.WriteLine("Selecciono opcion " + opcion);//obtengo la opción seleccionada
            DependiendoDeOpcion(opcion);

        }
        static void DependiendoDeOpcion(int opcion)
        {
            switch (opcion)//verifico la opción seleccionada para ver que método se invoca
            {
                case 1:
                    Console.WriteLine("Menu Alta Cliente");
                    //altaCliente();
                    break;
                case 2:
                    Console.WriteLine("Menu Alta Tarea");
                    //altaTarea();
                    break;
                case 3:
                    Console.WriteLine("Menu Alta Proyecto");
                    //altaProyecto();
                    break;
                case 4:
                    //agregarTareaAProyecto();
                    break;
                case 5:
                    //MostrarTareasDeUnProyecto();
                    break;
                case 6:
                    //MostrarDuraccionDeUnProyecto();
                    break;
                case 7:
                    //MostrarProyectosDeUnCliente();
                    break;
                case 8:
                    listarClientes();
                    break;
                case 9:
                    listarProyectos();
                    break;
                default:
                    Console.Write("Saliendo...");
                    break;
            }
        }
        static void listarClientes()
        {
            Console.WriteLine(emp.ListarClientes());
            Console.ReadKey();
            MostrarMenu();
        }
        static void listarProyectos()
        {
            Console.WriteLine(emp.ListarProyectos());
            Console.ReadKey();
            MostrarMenu();
        }

    }
}
