using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            Console.ReadKey();
            

 
        }
        public static Empresa emp = new Empresa();
        /*imprime en pantalla las opciones del menú*/
        static void MostrarMenu()
        {
            Console.WriteLine("Menú principal");
            Console.WriteLine("----------------");
            Console.WriteLine("1-Alta de Remitente");
            Console.WriteLine("2-Alta de Paquete");
            Console.WriteLine("3-Modificar Paquete");
            Console.WriteLine("4-Modificar Remitente");
            Console.WriteLine("5-Calcular Costo de Paquete");
            Console.WriteLine("6-Salir");
            Console.WriteLine("Seleccione una opción");
            int opcion = 0;
            int.TryParse(Console.ReadLine(), out opcion);
            VerificarOpcion(opcion);

        }
        /*metodo que verifica que metodo invocar de acuerdo a la opción selecionada por el usuario*/
        static void VerificarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AltaRemitente();
                    break;
                case 2: AltaPaquete();
                    break;
                case 3:
                    ModificarRemitente();
                    break;
                case 4: ModificarPaquete();
                    break;
                case 5:
                    CalcularCostoPaquete();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Presiones cualquier tecla para cerrar");
                    break;

            }
        }
        //Metodo que solicita los datos del Remitente
        static void  AltaRemitente(){
            Console.WriteLine("Ingrese Nombre del Remitente");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese  Direccion del remitente ");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese telefono");
            string telefono = Console.ReadLine();

            //si los datos son validos
            if (DatosValidosRemitentes(nombre , direccion, telefono))
            {
                //Enviamos los datos a la clase controladora
                string respuesta = emp.AltaRemitente(nombre, direccion, telefono);
                Console.WriteLine(respuesta);
            }

            
            MostrarMenu();
        }
        //Metodo que solicita los datos del paquete
        static void  AltaPaquete(){

            Console.WriteLine("Ingrese direccion de destino");
            string direccionDestino = Console.ReadLine();
            Console.WriteLine("Ingrese peso");
            int peso = 0;
            int.TryParse(Console.ReadLine(), out peso);
            Console.WriteLine("Ingrese precio base");
            decimal precioBase = 0;
            decimal.TryParse(Console.ReadLine(), out precioBase);
            Console.WriteLine("Seleccione un remitente");
            ListarRemitentes();
            Console.WriteLine("Ingrese el telefono del remitente seleccionado");
            string telefono = Console.ReadLine();

            if (emp.BuscarRemitente(telefono) == null)//verifica que exista el remitente
            {
                Console.WriteLine("El remitente no existe, seleccione la opción para dar de alta el mismo");
            }
            else if (telefono != "" && direccionDestino != "" && peso > 0 && precioBase > 0)

            {
                if (emp.AltaPaquete(direccionDestino, peso, precioBase, telefono))
                {
                    Console.WriteLine("El alta del paquete se realizó correctamente");
                }
                else
                {
                    Console.WriteLine("El alta del paquete no se realizó");
                }
            }

        }
        static void ListarRemitentes()
        {
            Console.WriteLine(emp.ListarRemitentes());
        }


        //Metodo que permite modificar un Remitente de una Lista
        static void   ModificarRemitente(){
            Console.WriteLine("Ingrese direccion");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Seleccione el remitente que desea modificar");
            ListarRemitentes();
            Console.WriteLine("Ingrese telefono del remitente que desea modificar");
            string telefono = Console.ReadLine();
            if (telefono != "" && direccion != "" && nombre != "")

            {
                Console.WriteLine(emp.ModificarRemitente(direccion, nombre, telefono));

            }


        }
        //Metodo que permite modificar un Paquete de una Lista
        static void   ModificarPaquete(){
            Console.WriteLine("Ingrese direccion de destino");
            string direccionDestino = Console.ReadLine();
            Console.WriteLine("Ingrese peso");
            int peso = 0;
            int.TryParse(Console.ReadLine(), out peso);
            Console.WriteLine("Ingrese precio base");
            decimal precioBase = 0;
            decimal.TryParse(Console.ReadLine(), out precioBase);
            Console.WriteLine("Seleccione el paquete a modificar");
            ListarPaquetes();
            Console.WriteLine("Ingrese el codigo del paquete seleccionado");
            int codigo = 0;
            if (int.TryParse(Console.ReadLine(), out codigo))
            {
                if (direccionDestino != "" && peso > 0 && precioBase > 0)
                {
                    Console.WriteLine(emp.ModificarPaquete(peso, precioBase, direccionDestino, codigo));

                }
            }

        }
        //muestra los datos de los paquetes existentes en el sistema
        static void ListarPaquetes()
        {
            Console.WriteLine(emp.ListarPaquetes());
        }

        /*Calcular el costo de un paquete sabiendo que el mismo depende de su peso:
 si el paquete pesa menos de un kilo, su costo es el precio base,
 si el paquete pesa entre 1 kilo y 3 kilos, el precio es el precio base más
un 10 %
 Si el paquete pesa más de 3 kilos el precio es el precio base más un
20%
*/
        static void CalcularCostoPaquete(){
            Console.WriteLine("Seleccione el paquete a modificar");
            ListarPaquetes();
            Console.WriteLine("Ingrese el codigo del paquete seleccionado");
            int codigo = 0;
            if (int.TryParse(Console.ReadLine(), out codigo))
            {
                Console.WriteLine(emp.CalcularCosto(codigo));
            }

        }

        //verificar datos
        static bool DatosValidosRemitentes(string nombre, string direccion, string telefono  )
        {
            bool valido = false;
            if(nombre != "" && direccion != "" && telefono != "" )
            {
                valido = true;
            }


            return valido;
        }

    }
}
