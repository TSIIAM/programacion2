using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico1_semana1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Mi primer Practico");
            MostrarNumerosIngresadosxUsuario();
            MostrarBienvenida();
            Console.WriteLine("Mi primer programa");
            CalcularDescuento();
            Console.WriteLine("Calcular descuento 30% para  2000");
            decimal descuentoObtenido = CalcularDescuento(2000, 30);
            Console.WriteLine("El 30%  de descuento sobre 2000 es: " + descuentoObtenido);
            Console.WriteLine("Mi segundo metodo");
            CalcularParesIncluidos();
            Console.ReadKey();
            */
            //muestraPares();
            //Console.ReadKey();

            mostrarIntIncluido();
            Console.ReadKey();
        }

        static void MostrarNumeros(int inicio, int fin)
        {
            for (int x = inicio; x <= fin; x++)
            {
                Console.WriteLine("El numero es:" + x);
            }
        }
        static void MostrarNumeros()
        {
            for (int x = 1; x <= 50; x++)
            {
                Console.WriteLine("El numero es:" + x);
            }
        }
        static void MostrarNumerosIngresadosxUsuario()
        {
            Console.WriteLine("Ingrese numero de inicio");
            int inicio = 0;
            int.TryParse(Console.ReadLine(), out inicio);
            Console.WriteLine("Ingrese numero de fin");
            int fin = 10;
            int.TryParse(Console.ReadLine(), out fin);
            MostrarNumeros(inicio, fin);
        }

        static void MostrarBienvenida()
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);
        }
        static void CalcularDescuento()
        {
            Console.Write("Ingrese un monto: ");
            decimal monto = 4;
            decimal.TryParse(Console.ReadLine(), out monto);
            Console.WriteLine("El monto es : " + monto);
            Console.Write("Ingrese una tasa: ");
            decimal tasa = 11;
            decimal.TryParse(Console.ReadLine(), out tasa);
            Console.WriteLine("La tasa es : " + tasa);
            decimal descuento = monto * tasa / 100;
            Console.WriteLine("El Descuento es : " + descuento);
        }
        static decimal CalcularDescuento(decimal monto, decimal tasa)
        {
            decimal descuento = monto * tasa / 100;
            return descuento;
        }
        static void muestraPares() {
            Console.WriteLine("Ingrese primer numero");
            int primerNumero = 0;
            int.TryParse(Console.ReadLine(), out primerNumero);
            Console.WriteLine("Ingrese segundo numero");
            int segundoNumero = 0;
            int.TryParse(Console.ReadLine(), out segundoNumero);

            int min = 0;
            int max = 0;

            if (primerNumero > segundoNumero)
            {
                min = segundoNumero;
                max = primerNumero;
            }
            else {
                min = primerNumero;
                max = segundoNumero; 
            }

            for (int i = min; i <= max; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine("El numero par es " + i);
                } 
            }



        }
        /*Dados un valor y dos topes indicar si el valor esta comprendido entre los topes(inclusive)*/

        static void mostrarIntIncluido() {
            Console.WriteLine("Dados un valor y dos topes, indicar si el valor esta comprendido entre los topes");
            //obtenemos los valores
            Console.WriteLine("Ingrese un valor");
            int valor = 0;
            int.TryParse(Console.ReadLine(), out valor);
            Console.WriteLine("Ingreso valor " + valor);

            Console.WriteLine("Ingrese un minimo");
            int minimo = 0;
            int.TryParse(Console.ReadLine(), out minimo);
            Console.WriteLine("Ingreso valor " + minimo);

            Console.WriteLine("Ingrese un maximo");
            int maximo = 0;
            int.TryParse(Console.ReadLine(), out maximo);
            Console.WriteLine("Ingreso valor " + maximo);


            //realizamos condicional para ordenar los topes
            int min = minimo;
            int max = maximo;

            if (minimo > maximo)
            {
                min = maximo;
                max = min;
            }
            //condicional para ver si esta incluido dentro de los topes
            if (valor < min)
            {
                Console.WriteLine("El valor que usted ingreso es menor y no esta incluido en los topes.");
            }
            else if (valor > max)
            {
                Console.WriteLine("El valor que usted ingreso es mayor y no esta incluido en los topes.");
            }
            else {
                Console.WriteLine("El valor que usted ingreso esta incluido dentro de los topes."); 
            }
       



        }

    }
}
