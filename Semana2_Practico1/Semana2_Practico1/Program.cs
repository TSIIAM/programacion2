using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Practico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota chico = new Mascota();
            //Vendedor vendedor = new Vendedor();
            pedirDatosMascota(chico);
            chico.mostrarMascota();
            Console.WriteLine(chico);



            #region readkey
            Console.ReadKey();
            #endregion

        }
        //endMain
        static void pedirDatosMascota(Mascota mascota)
        {
            Console.WriteLine("Ingrese Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Tipo de Mascota");
            string tipo = Console.ReadLine();
            Console.WriteLine("Ingrese Precio de Mascota");
            decimal precio = 0;
            decimal.TryParse(Console.ReadLine(), out precio);
            mascota.modificarAtributos(tipo, precio, nombre);



        }
        //end pedirDatosMascota


    }
}
