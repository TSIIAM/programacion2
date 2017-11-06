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
                       // altaCategoria();
                        break;
                    case 5:
                        //aumentoSueldos();
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
           
        }

        private static void altaFuncionarioPresupuestado()
        {
        }
        public static void listadoFuncionariosXCargo()
        {
        }

        private static void altaCategoria()
        {
           
        }

        private static void listadoFuncionariosAumento()
        {
            //Console.WriteLine(emp.listadoFuncionariosAumento());
        }

       /* private static void aumentoSueldos()
        {
            if (emp.aumentoSueldos())
            {
                Console.WriteLine("El aumento se realizo correctamente");
            }
               
        }*/
        private static void salir()
        {
            Console.Clear();

        }

    }
}
