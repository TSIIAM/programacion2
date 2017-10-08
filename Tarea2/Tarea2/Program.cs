using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea2Logica;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {

            MostrarMenu();
            Console.ReadKey();
        }


        static void MostrarMenu()
        {
            Console.WriteLine("Menu principal");
            Console.WriteLine("1-Alta Pasaje");
            Console.WriteLine("2-Alta Vuelo");
            Console.WriteLine("3-Listar clientes por fecha de compra de pasaje");
            Console.WriteLine("4-Alta Compania");
            Console.WriteLine("5-Alta Cliente");
            Console.WriteLine("6-Salir");
            Console.Write("Seleccione una opcion :  ");
            int opcion = Convert.ToInt32(Console.ReadLine());//obtengo la opción seleccionada
            Console.WriteLine("Selecciono opcion " + opcion);
            DependiendoDeOpcion(opcion);

            

        }

        static void DependiendoDeOpcion(int opcion)
        {
            switch (opcion)//verifico la opción seleccionada para ver que método se invoca
            {
                case 1:
                    Console.Write("Alta Pasaje");
                    //altaPasaje();
                    break;
                case 2:
                    Console.Write("Alta Vuelo");
                   // altaVuelo();
                    break;
                case 3:
                    Console.Write("Listar clientes por fecha de compra de Pasaje");
                    // listarClientePorFechaCompraPasaje();
                    break;
                case 4:
                    Console.Write("Alta Compania");
                    // altaCompania();
                    break;
                case 5:
                    Console.Write("Alta Cliente");
                    // altaCliente();
                    break;
                case 6:
                    Console.Write("Saliendo...");
                    
                    break;
                
            }

        }
    }
}
