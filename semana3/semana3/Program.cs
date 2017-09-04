using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iniciando Programa...");
            MostrarMenu();
            ElegirOpcion();

            #region Fin
            //Console.WriteLine("Cerrando programa...");
            Console.ReadKey();
            #endregion
        }

        static void MostrarMenu() {
            Console.WriteLine("1_ Alta Local");
            Console.WriteLine("2_ Alta Inspector");
            Console.WriteLine("3_ Modificar Local");
            Console.WriteLine("4_ Modificar Inspector");
            Console.WriteLine("5_ Listar Locales ");
            Console.WriteLine("6_ Listar Inspectores");
            Console.WriteLine("7_ Salir");
             
        }
        static void ElegirOpcion() {
            Console.WriteLine("Seleccione una opción ");
            int opcion = 0;
            int.TryParse(Console.ReadLine(), out opcion);
            Console.WriteLine("Usted Selecciono la opcion " + opcion);
            VerificarOpcion(opcion);

        }
        static void VerificarOpcion(int opcion) {
            switch (opcion) {
                case 1:
                    AltaLocal();
                    break;
                case 2:
                    AltaInspector();
                    break;
                case 3:
                    ModificarLocal();
                    break;
                case 4:
                    ModificarInspector();
                    break;
                case 5:
                    ListarLocales();
                    break;
                case 6:
                    ListarInspectores();
                    break;
                default: Console.Clear();
                    Console.WriteLine("Presione cualquier tecla para cerrar el programa");
                    break;
            }

        }
        static void AltaLocal() { Console.Write("Alta Local... ");   }
        static void AltaInspector() { Console.Write("Alta Inspector... "); }
        static void ModificarLocal() { Console.Write("Modificar Local... "); }
        static void ModificarInspector() { Console.Write("Modificar Inspector... "); }
        static void ListarLocales() { Console.Write("Listar Locales... "); }
        static void ListarInspectores() { Console.Write("Listar Inspectores... "); }
        

    }
}

