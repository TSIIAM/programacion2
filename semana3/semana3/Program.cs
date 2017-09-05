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
            

            #region Fin
            //Console.WriteLine("Cerrando programa...");
            Console.ReadKey();
            #endregion
        }
        //variable utilizada por el menu.
        private static Empresa emp = new Empresa();

        static void MostrarMenu() {
            Console.WriteLine("1_ Alta Local");
            Console.WriteLine("2_ Alta Inspector");
            Console.WriteLine("3_ Modificar Local");
            Console.WriteLine("4_ Modificar Inspector");
            Console.WriteLine("5_ Listar Locales ");
            Console.WriteLine("6_ Listar Inspectores");
            Console.WriteLine("7_ Salir");
            ElegirOpcion();

        }
        static void ElegirOpcion() {
            Console.WriteLine("Seleccione una opción ");
            int opcion = 0;
            int.TryParse(Console.ReadLine(), out opcion);
            Console.WriteLine("Usted Selecciono la opcion " + opcion);
            
            VerificarOpcion(opcion);

        }
        static void VerificarOpcion(int opcion) {
            Console.Clear();
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
        static void AltaLocal() {
            Console.WriteLine(" Menu Alta Local " + "\n");
            Console.WriteLine("Ingrese Direccion");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese Razon Social");
            string razonSocial = Console.ReadLine();
            Console.WriteLine("Ingrese  Telefono");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese  Metros Cuadrados");
            decimal CantMetrosCuadrados = 0;
            decimal.TryParse(Console.ReadLine(), out CantMetrosCuadrados);

            if (DatosValidosLocal(direccion, telefono, razonSocial, CantMetrosCuadrados)) {
                emp.AltaLocal(direccion, telefono, razonSocial, CantMetrosCuadrados);
            }
            MostrarMenu();
        }
        static void AltaInspector() { 
            Console.WriteLine(" Menu Alta Inspector " + "\n");
            Console.WriteLine("Ingrese Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese cedula");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese  Codigo de Funcionario");
            int codigoFuncionario = 0;
            int.TryParse(Console.ReadLine(), out codigoFuncionario);

            if (DatosValidosInspector(nombre, cedula, codigoFuncionario) )
            {
                emp.AltaInspector(nombre, cedula, codigoFuncionario);
            }
            MostrarMenu();
        }
        static void ModificarLocal() { Console.WriteLine("Modificar Local... "); }
        static void ModificarInspector() { Console.WriteLine("Modificar Inspector... "); }
        static void ListarLocales() { Console.WriteLine("Listar Locales... "); }
        static void ListarInspectores() { Console.WriteLine("Listar Inspectores... "); }


        #region ValidarDatos
        /*Metodo para verificar si los datos ingresados por el usuario son validos*/
        static bool DatosValidosLocal(string direccion, string telefono, string razonSocial, decimal CantMetrosCuadrados) {
            bool valido = false;
                if(direccion  != "" && telefono != ""  && razonSocial != "" && CantMetrosCuadrados  > 0) {
                valido = true;  
            }

       
            return valido;
        }
        static bool DatosValidosInspector(string nombre, string cedula,  int codigoFuncionario)
        {
            bool valido = false;
            if (nombre != "" && cedula != ""  && codigoFuncionario > 0)
            {
                valido = true;
            }
            return valido;
        }
        #endregion


    }
}

