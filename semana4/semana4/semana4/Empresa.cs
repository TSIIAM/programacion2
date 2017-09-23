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
        public bool AltaPaquete(string direccion, int peso, decimal precioBase, string telefono)
        {
            bool alta = false;
            int cantElementos = this.paquetes.Count;

            Remitente remitente = BuscarRemitente(telefono);
            if (remitente != null)
            {
                //(Remitente remitente, int peso, string direccion, decimal precioBase)
                this.paquetes.Add(new Paquete(remitente ,peso, direccion));
            }
            if (paquetes.Count > cantElementos)
            {
                alta = true;
            }
            return alta;
        }
        //metodo que retorna un texto con los datos de los paquetes existentes en el sistema
        public string ListarPaquetes()
        {
            string datos = "";
            for (int i = 0; i < paquetes.Count; i++)
            {
                datos += paquetes[i] + "\n";
            }
            return datos;
        }
        //metodo que permite modificar un paquete
        public string ModificarPaquete(int peso, decimal precioBase, string direccionDestino, int codigo)
        {
            Paquete p = BuscarPaquete(codigo);
            if (p != null)
            {

                p.ModificarPaquete(peso, direccionDestino);

            }
            return p.ToString();
        }
        //metodo que permite buscar si existe un paquete con el codigo recibido por parametro
        public Paquete BuscarPaquete(int codigo)
        {
            int i = 0;
            Paquete p = null;
            while (i < paquetes.Count && p == null)
            {
                if (paquetes[i].Numero == codigo)
                {
                    p = paquetes[i];
                }
                i++;
            }
            return p;
        }
        //metodo que devuelve el costo del paquete que tiene el codigo que se recibe por parametro
        public decimal CalcularCosto(int codigo)
        {
            decimal costo = 0;
            Paquete paquete = BuscarPaquete(codigo);
            if (paquete != null)
            {
                costo = paquete.CalcularCosto();
            }
            return costo;
        }
        //metodo que devuelve un texto con los datos de los remitentes que existen en el sistema
        public string ListarRemitentes()
        {
            string datos = "";
            for (int i = 0; i < remitentes.Count; i++)
            {
                datos += remitentes[i] + "\n";
            }
            return datos;
        }
        //metodo que permite modificar los datos del remitente que tiene el telefono que se recibe por parametro
        public string ModificarRemitente(string direccion, string nombre, string telefono)
        {


            Remitente r = BuscarRemitente(telefono);
            if (r != null)
            {

                r.ModificarDatos(direccion, nombre);

            }
            return r.ToString();
        }
        public bool AltaSobre(string direccionDestino, int peso, string telefono,
           string tamanio)
        {

            bool alta = false;
            int cantActual = this.paquetes.Count;
            Remitente r = this.BuscarRemitente(telefono);
            if (r != null)
            {
                this.paquetes.Add(new Sobre(direccionDestino, r, peso, tamanio));
            }
            if (cantActual < this.paquetes.Count)
            {
                alta = true;
            }
            return alta;

        }
    }
}
