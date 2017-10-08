using System;
using tarea2Logica;

namespace Tarea2
{
    class Program
    {
        private static Empresa emp = new Empresa();
        static void Main(string[] args)
        {
             
            Console.WriteLine("Iniciando Programa...");
            MostrarMenu();

            Console.ReadKey();
        }

        

        static void MostrarMenu()
        {
            Console.WriteLine("Bienvenido al menu principal");
            Console.WriteLine("1-Alta Pasaje");
            Console.WriteLine("2-Alta Vuelo");
            Console.WriteLine("3-Listar clientes por fecha de compra de pasaje");
            Console.WriteLine("4-Alta Compania");
            Console.WriteLine("5-Alta Cliente");
            Console.WriteLine("6-Listar Companias");
            Console.WriteLine("7-Listar Vuelos");
            Console.WriteLine("8-Listar Pasajes");
            Console.WriteLine("9-Listar Clientes");
            Console.WriteLine("10-Salir");
            Console.Write("Seleccione una opcion :  ");
           
            int opcion = 0;
            int.TryParse(Console.ReadLine(), out opcion);
            Console.WriteLine("Selecciono opcion " + opcion);//obtengo la opción seleccionada
            DependiendoDeOpcion(opcion);
        }
        /// <summary>
        /// Dependiendo de la opcion elegida del menu el switch llamara a un alta donde se solicitara datos
        /// </summary>
        /// <param name="opcion"></param>
        static void DependiendoDeOpcion(int opcion)
        {
            switch (opcion)//verifico la opción seleccionada para ver que método se invoca
            {
                case 1:
                    altaPasaje();
                    break;
                case 2:     
                   altaVuelo();
                    break;
                case 3:
                    listarClientePorFechaCompraPasaje();
                    break;
                case 4:
                     altaCompania();
                    break;
                case 5:
                     altaCliente();
                    break;
                case 6:
                    listarCompanias();
                    break;
                case 7:
                    listarVuelos();
                    break;
                case 8:
                    listarPasajes();
                    break;
                case 9:
                    listarClientes();
                    break;
                default:
                    Console.Write("Saliendo...");
                    
                    break;
                
            }

        }
        #region metodosInput
        static void altaPasaje()
        {
            Console.WriteLine("Menu Alta Pasaje");
            Console.WriteLine("1- Listar Vuelos");
            Console.WriteLine("2- Dar Alta Pasaje");
            int opcion = 0;
            int.TryParse(Console.ReadLine(), out opcion);
            Console.WriteLine("Selecciono opcion " + opcion);//obtengo la opción seleccionada
            if (opcion == 1)
            {
                Console.WriteLine(emp.ListarVuelos());
                altaPasaje();

            } else if (opcion == 2) {
                Console.WriteLine("Por favor Ingrese los siguientes Datos...");
            } else {
                Console.WriteLine("Por favor eliga una de las 2 opciones");
            }


          
            Console.WriteLine("Numero de Asiento");
            int numAsiento = 1;
            int.TryParse(Console.ReadLine(), out numAsiento);
            Console.WriteLine("Identificador del Vuelo");
            int idVuelo = 1;
            int.TryParse(Console.ReadLine(), out idVuelo);
            Vuelo elVuelo = emp.BuscarVuelo(idVuelo);
            DateTime fechaAhora = DateTime.Now;
            if (datosValidosInt(numAsiento) && elVuelo != null)
            {
                if (emp.AltaPasaje(numAsiento, elVuelo, fechaAhora))
                {
                    Console.WriteLine("Pasaje Ingresado con exito");
                    Console.WriteLine(emp.ListarPasajes());
                }
                else {
                    Console.WriteLine("Corrobore los datos no esten duplicados");
                }
            }
            else {
                Console.WriteLine("Ingrese datos correctos");
            }

            Console.ReadKey();
            Console.Clear();
            MostrarMenu();

        }
        static void altaVuelo()
        {
            Console.WriteLine("Menu Alta Vuelo");
            Console.WriteLine("1- Listar Companias");
            Console.WriteLine("2- Dar Alta Vuelo Comercial");
            Console.WriteLine("3- Dar Alta Vuelo Charter");
            int opcion = 0;
            int.TryParse(Console.ReadLine(), out opcion);
            Console.WriteLine("Selecciono opcion " + opcion);//obtengo la opción seleccionada
            if (opcion == 1)
            {
                Console.WriteLine(emp.ListarCompanias());
                altaVuelo();
            }
            else if(opcion == 2)
            {
                altaVueloComercial();

            }
            else if (opcion == 3)
            {
                altaVueloCharter();
            }

        }
        static void altaVueloComercial() {
            
            Console.WriteLine("Menu  de Alta Vuelo Comercial");
            Console.WriteLine("Ingrese destino");
            string destino = Console.ReadLine();
            Console.WriteLine("Nombre Compania");
            string razonSocial = Console.ReadLine();
            Compania compania = emp.BuscarCompania(razonSocial);
            Console.WriteLine("Ingrese escalas separados por coma,");
            string aeropuertos = Console.ReadLine();
            string[] arrAeropuertos = aeropuertos.Split(',');
            Console.WriteLine("Ingrese una fecha Formato  mes/dia/año hora:minuto:segundo ");
            DateTime fechaHoraSalida;
            if (DateTime.TryParse(Console.ReadLine(), out fechaHoraSalida))
            {
                Console.WriteLine(fechaHoraSalida.ToString());
                if (emp.AltaVueloComercial(destino, razonSocial, fechaHoraSalida, arrAeropuertos))
                {
                    Console.WriteLine("Vuelo Ingresado con exito");
                    Console.WriteLine(emp.ListarVuelos());
                    MostrarMenu();
                }
                else {
                    Console.WriteLine("Corrobore los datos no esten duplicados");
                    MostrarMenu();
                }
            }
            else
            {
                Console.WriteLine("Por favor intente de nuevo la fecha de horaSalida");
                altaVueloComercial();
            }




        }
        static void altaVueloCharter()
        {
            // public bool AltaVueloComercial(string destino, Compania compania, DateTime fechaHoraSalida, params string[] aeropuertos
            Console.WriteLine("Menu  de Alta Vuelo Comercial");
            Console.WriteLine("Ingrese destino");
            string destino = Console.ReadLine();
            Console.WriteLine("Nombre Compania");
            string razonSocial = Console.ReadLine();
            Compania compania = emp.BuscarCompania(razonSocial);
            Console.WriteLine("Ingrese escalas separados por coma,");
            string aeropuertos = Console.ReadLine();
            string[] arrAeropuertos = aeropuertos.Split(',');
            Console.WriteLine("Ingrese una fecha Formato  mes/dia/año hora:minuto:segundo ");
            DateTime fechaHoraSalida;
            if (DateTime.TryParse(Console.ReadLine(), out fechaHoraSalida))
            {
                Console.WriteLine(fechaHoraSalida.ToString());
                if (emp.AltaVueloCharter(destino, razonSocial, fechaHoraSalida))
                {
                    Console.WriteLine("Vuelo Ingresado con exito");
                    Console.WriteLine(emp.ListarVuelos());
                    MostrarMenu();
                }
                else
                {
                    Console.WriteLine("Corrobore los datos no esten duplicados");
                    MostrarMenu();
                }
            }
            else
            {
                Console.WriteLine("Por favor intente de nuevo la fecha de horaSalida");
                altaVueloCharter();
            }

        }
    



        static void listarClientePorFechaCompraPasaje()
        {
            Console.WriteLine("Listar los clientes por la fecha de compra del pasaje");
            Console.WriteLine("Ingrese Mes");
            int mes = 1;
            int.TryParse(Console.ReadLine(), out mes);
            Console.WriteLine("Ingrese Dia");
            int dia = 1;
            int.TryParse(Console.ReadLine(), out dia);

            Console.WriteLine(emp.ListarClientesPorFechaCompraPasaje(mes,dia));

        }
        static void altaCompania()
        {
            Console.WriteLine("Menu  de Alta Compania");
            Console.WriteLine("Ingrese nombre");
            string razonSocial = Console.ReadLine();
            Console.WriteLine("Ingrese telefono");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese direccion");
            string direccion = Console.ReadLine();
            if (emp.AltaCompania(razonSocial, telefono, direccion))
            {
                Console.WriteLine("Compania Ingresada con exito");
                MostrarMenu();
            }
            else {
                Console.WriteLine("Corrobore los datos no esten duplicados  ");
            }

        }
        static void altaCliente()
        {
            Console.WriteLine("Menu  de Alta Compania");
            Console.WriteLine("Ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese telefono");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese direccion");
            string celular = Console.ReadLine();
            Console.WriteLine("Ingrese Pasaporte");
            int pasaporte = 0;
            int.TryParse(Console.ReadLine(), out pasaporte);
            Console.WriteLine(emp.ListarPasajes());
            Console.WriteLine("Eliga pasaje por Identificador");
            int numAsiento = 0;
            int.TryParse(Console.ReadLine(), out numAsiento);
            Console.WriteLine(emp.ListarVuelos());
            Console.WriteLine("Eliga Vuelo por Identificador");
            int idVuelo = 0;
            int.TryParse(Console.ReadLine(), out idVuelo);


            if (emp.AltaCliente(nombre,apellido,celular,pasaporte,numAsiento,idVuelo))
            {
                Console.WriteLine("Cliente Ingresada con exito");
                MostrarMenu();
            }
            else
            {
                Console.WriteLine("Corrobore los datos no esten duplicados  ");
                altaCliente();
            }
        }
        static void listarCompanias()
        {
            Console.WriteLine(emp.ListarCompanias());
            MostrarMenu();
        }
        static void listarVuelos()
        {
            Console.WriteLine(emp.ListarVuelos());
            MostrarMenu();
        }
        static void listarPasajes()
        {
            Console.WriteLine(emp.ListarPasajes());
            MostrarMenu();
        }
        static void listarClientes()
        {
            Console.WriteLine(emp.ListarClientes());
            MostrarMenu();
        }

        #endregion
        #region validarDatos
        static bool datosValidosInt(int input)
        {
            bool valido = false;
            if (input > 0)
            {
                valido = true;
            }
            return valido;
        }

        static bool datosValidosStrings(params string[] inputs)
        {
            bool valido = false;
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == "")
                {
                      valido = false;
                      break;
                }
                else {
                      valido = true;
                }
            }
            return valido;
        }
       

        public static bool IsDateTime(string fechaHoraSalida)
        {
            DateTime tempDate;
            return DateTime.TryParse(fechaHoraSalida, out tempDate);
        }
        #endregion
        #region utilitarios
        public int laHora()
        {
            Random rnd = new Random();
            int hora = rnd.Next(0, 24);
            return hora;

        }
        public int elMinuto()
        {
            Random rnd = new Random();
            int minuto = rnd.Next(0, 61);
            return minuto;
        }
        public int elSegundo()
        {
            Random rnd = new Random();
            int segundo = rnd.Next(0, 61);
            return segundo;
        }
        #endregion
    }

}
