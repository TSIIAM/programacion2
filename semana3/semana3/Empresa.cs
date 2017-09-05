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

        #region metodos de  AltaLocal
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
                            "Cantidad de Metros Cuadrados: " + CantMetrosCuadrados);

           Local loc = BuscarLocal(razonSocial);
            if (loc == null) {
                loc = new Local(direccion, telefono, razonSocial, CantMetrosCuadrados);
                locales.Add(loc);
                Console.WriteLine("Datos Ingresados!.");
            }
            else
            {
                Console.WriteLine("Datos ya existen.");
            }

        }
        public Local BuscarLocal(string razonSocial) {
            Local l = null;
            int  i = 0;
            bool existe = false;
            while (i < locales.Count && !existe) {
                if (locales[i].RazonSocial == razonSocial ) {
                    existe = true;
                    l = locales[i];
                }
            }
            return l;
        }
        #endregion

        #region metodos de AltaInspector
        /// <summary>
        /// Permite crear una instancia inspector  y agregarla a la lista de inspectores.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cedula"></param>
        /// <param name="codigoFuncionario"></param>
        public void AltaInspector(string nombre,  string cedula, int codigoFuncionario) {
            Console.Clear();
            Console.WriteLine("Ingresando Datos....");
            Console.WriteLine("Nombre : " + nombre + "\n" +
                            "Cedula: " + cedula + "\n" +
                            "Codigo de Funcionario: " + codigoFuncionario + "m3");

            Inspector insp = BuscarInspector(codigoFuncionario);
            if (insp == null)
            {
                insp = new Inspector(nombre, cedula, codigoFuncionario);
                inspectores.Add(insp);
                Console.WriteLine("Datos Ingresados!.");
            }
            else {
                Console.WriteLine("Datos ya existen.");
            }

            
        }
        public Inspector BuscarInspector(int codigoFuncionario)
        {
            Inspector insp = null;
            int i = 0;
            bool existe = false;
            while (i < inspectores.Count && !existe)
            {
                if (inspectores[i].CodigoFuncionario == codigoFuncionario)
                {
                    existe = true;
                    insp = inspectores[i];
                }
            }
            return insp;
        }
        #endregion


    }


}
