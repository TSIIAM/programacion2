using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3
{
    class Empresa
    {

        private List<Local> locales = new List<Local>();
        private List<Inspector> inspectores = new List<Inspector>();


        /// <summary>
        /// Permite crear una instancia local y agregarla a la lista de locales.
        /// </summary>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="razonSocial"></param>
        /// <param name="CantMetrosCuadrados"></param>
        public void AltaLocal(string direccion, string telefono, string razonSocial, decimal CantMetrosCuadrados)
        {
            Console.Clear();
            Console.WriteLine("Ingresando Datos....");
            Console.WriteLine("Direccion: " + direccion + "\n" +
                            "Telefono: " + telefono + "\n" +
                            "Razon Social: " + razonSocial + "\n" +
                            "Cantidad de Metros Cuadrados: " + CantMetrosCuadrados + "m3");
            Local loc = new Local(direccion, telefono, razonSocial,CantMetrosCuadrados);
            locales.Add(loc);
            Console.WriteLine("Datos Ingresados con Exito!.");

        }


    }

    
}
