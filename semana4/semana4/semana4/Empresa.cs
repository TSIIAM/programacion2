using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4
{
    class Empresa
    {
        private List<Remitente> remitentes = new List<Remitente>();
        private List<Paquete> paquetes = new List<Paquete>();



        public string AltaRemitente(string nombre, string direccion, string telefono) {

            BuscarRemitente(telefono);
            Console.Clear();
            string respuesta;
            respuesta = " Ingresando Datos...." + "\n" +
                            "Nombre: " + nombre + "\n" +
                            "Direccion: " + direccion + "\n" +
                            "Telefono: " + telefono + "\n";
           
            //creamos una variable de objeto Remitente y buscamos si existe ya ese remitente
            Remitente rem = BuscarRemitente(telefono);
            if (rem == null)
            {
                rem = new Remitente(nombre, direccion, telefono);
                remitentes.Add(rem);
                respuesta += "Remitente Ingresado!.";
            } else
            {
                 respuesta += "Remitente ya existe";
            }

            return respuesta;
            
            


        }
        /// <summary>
        /// Metodo para buscar Remitente mediante el telefono.
        /// </summary>
        /// <param name="telefono"></param>
        /// <returns></returns>
        public Remitente BuscarRemitente(string telefono) {
            Remitente rem = null;
            int i = 0;
            bool yaExiste = false;
            while (i < remitentes.Count && yaExiste) {

                if (remitentes[i].Telefono == telefono) {
                    rem = remitentes[i];
                    yaExiste = true;
                }
                i++;

            }

            return rem;
        }
    }
}
