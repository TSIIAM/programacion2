using System;
using System.Collections.Generic;
using System.Linq;
 


namespace tarea2Logica
{
    public class Empresa
    {
        private List<Compania> companias = new List<Compania>();
        private List<Vuelo> vuelos = new List<Vuelo>();
        private List<Cliente> clientes = new List<Cliente>();
        private List<Pasaje> pasajes = new List<Pasaje>();

        public Empresa()
        {
            CargarDatosPrueba();

        }

        public void CargarDatosPrueba()
        {
            this.AltaCompania("Iberia", "555444", "mercedes 2020");
            this.AltaCompania("TransAns", "666888", "Colonia 1212");

            this.AltaVueloCharter("Madrid", "Iberia", new DateTime(2017, 10, 26, 18, 53, 30));
            this.AltaVueloCharter("Barcelona", "Iberia", new DateTime(2017, 10, 28, 19, 20, 30));
            this.AltaVueloCharter("Miami", "TransAns", new DateTime(2017, 10, 28, 19, 20, 30));
            this.AltaVueloCharter("Los Angeles", "TransAns", new DateTime(2017, 10, 26, 19, 20, 30));
            this.AltaVueloComercial("Paris", "Iberia", new DateTime(2017, 10, 21, 18, 20, 30), "Madrid", " Paris");
            this.AltaVueloComercial("Berlin", "TransAns", new DateTime(2017, 10, 19, 16, 20, 30), "Madrid", " Berlin");

            this.AltaPasaje(1, vuelos[1], new DateTime(2017, 10, 5, 16, 20, 30));
            this.AltaPasaje(3, vuelos[1], new DateTime(2017, 10, 4, 16, 20, 30));
            this.AltaPasaje(4, vuelos[2], new DateTime(2017, 10, 3, 16, 20, 30));
            this.AltaPasaje(5, vuelos[2], new DateTime(2017, 10, 5, 16, 20, 30));
            this.AltaPasaje(2, vuelos[3], new DateTime(2017, 10, 4, 16, 20, 30));


            this.AltaCliente("Gabriel", "Rosas", "099666333", 113456, 1, 2);
            this.AltaCliente("Adrian", "Sanz", "099778855", 123456, 3, 2);
            this.AltaCliente("Rodrigo", "Marquez", "099124578", 124578, 4, 3);
            this.AltaCliente("Elena", "Puentes", "093635241", 326598, 5, 3);

        }



        public bool AltaCompania(string razonSocial, string telefono, string direccion)
        {
            bool dioAlta;
            Compania existeCompania = BuscarCompania(razonSocial);
            if (existeCompania == null)
            {

                Compania nuevaCompania = new Compania(razonSocial, telefono, direccion);
                companias.Add(nuevaCompania);
                dioAlta = true;
                return dioAlta;
            }
            dioAlta = false;
            return dioAlta;
        }
        public Compania BuscarCompania(string razonSocial)
        {
            Compania existeCompania = null;

            foreach (Compania comp in companias)
            {
                if (comp.RazonSocial == razonSocial)
                {
                    existeCompania = comp;

                }
            }
            return existeCompania;
        }
        public string ListarCompanias()
        {
            string listadoCompanias = "";

            foreach (Compania comp in companias)
            {
                listadoCompanias += "_________" + " \n" + comp.RazonSocial + " \n";
            }

            return listadoCompanias;
        }

        public bool AltaVueloComercial(string destino, string razonSocial, DateTime fechaHoraSalida, params string[] aeropuertos)
        {
            bool dioAlta;
            Compania existeCompania = BuscarCompania(razonSocial);
            if (existeCompania == null)
            {
                dioAlta = false;
                return dioAlta;
            }
            Vuelo nuevoVueloComercial = new VueloComercial(destino, existeCompania, fechaHoraSalida, aeropuertos);
            vuelos.Add(nuevoVueloComercial);
            dioAlta = true;
            return dioAlta;
        }
        public bool AltaVueloCharter(string destino, string razonSocial, DateTime fechaHoraSalida)
        {
            bool dioAlta;
            Compania existeCompania = BuscarCompania(razonSocial);
            if (existeCompania == null)
            {
                dioAlta = false;
                return dioAlta;
            }
            Vuelo nuevoVueloCharter = new VueloCharter(destino, existeCompania, fechaHoraSalida);
            vuelos.Add(nuevoVueloCharter);
            dioAlta = true;
            return dioAlta;
        }
        public Vuelo BuscarVuelo(int idVuelo)
        {
            Vuelo existeVuelo = null;

            foreach (Vuelo vuelo in vuelos)
            {
                if (vuelo.IdVuelo == idVuelo)
                {
                    existeVuelo = vuelo;

                }
            }
            return existeVuelo;

        }
        public string ListarVuelos()
        {
            string listadoVuelos = " ";

            foreach (Vuelo vuelo in vuelos)
            {
                listadoVuelos += "_______________________._________________" + " \n" + vuelo.ToString() + " \n";
            }

            return listadoVuelos;
        }

        public bool AltaPasaje(int numAsiento, Vuelo vuelo,DateTime fechaCompra)
        {
            bool dioAlta;
            Vuelo existeVuelo = BuscarVuelo(vuelo.IdVuelo);


            if (existeVuelo != null)
            {
                Pasaje existePasaje = BuscarPasaje(numAsiento, vuelo.IdVuelo);
                if (existePasaje == null) {
                    Pasaje nuevoPasaje = new Pasaje(numAsiento, vuelo, fechaCompra);
                    pasajes.Add(nuevoPasaje);
                    dioAlta = true;
                    return dioAlta;

                }

            }
            dioAlta = false;
            return dioAlta;

        }
        public string ListarPasajes()
        {
            string listadoPasajes = "";

            foreach (Pasaje pasaje in pasajes)
            {
                listadoPasajes += "_______________________._________________" + " \n" + pasaje.ToString() + " \n";
            }

            return listadoPasajes;
        }
        public Pasaje BuscarPasaje(int numAsiento, int idVuelo)
        {
            Pasaje existePasaje = null;

            foreach (Pasaje pasaje in pasajes)
            {
                if (pasaje.NumAsiento == numAsiento && pasaje.delVuelo.IdVuelo == idVuelo)
                {
                    existePasaje = pasaje;
                }
            }
            return existePasaje;
        }


        public bool AltaCliente(string nombre, string apellido, string celular, int pasaporte, int numAsiento, int idVuelo)
        {
            bool dioAlta;
            Pasaje existePasaje = BuscarPasaje(numAsiento, idVuelo);
            if (existePasaje != null)
            {

                Cliente existeCliente = BuscarCliente(pasaporte);
                if (existeCliente == null)
                {
                    Cliente nuevoCliente = new Cliente(nombre, apellido, celular, pasaporte, existePasaje);
                    clientes.Add(nuevoCliente);
                    dioAlta = true;
                    return dioAlta;
                }
            }
            dioAlta = false;
            return dioAlta;
        }
        public Cliente BuscarCliente(int pasaporte)
        {
            Cliente existeCliente = null;

            foreach (Cliente cliente in clientes)
            {
                if (cliente.Pasaporte.Equals(pasaporte))
                {
                    existeCliente = cliente;
                }
            }
            return existeCliente;
        }
        public string ListarClientes()
        {
            string listadoClientes = "";

            foreach (Cliente cliente in clientes)
            {
                listadoClientes += "_______________________._________________" + " \n" + cliente.ToString() + " \n";
            }

            return listadoClientes;

        }


        public string ListarClientesPorFechaCompraPasaje(int mes, int dia)
        {
            string listado = "";
            foreach (Pasaje pasaje in pasajes)
            {
                if(pasaje.FechaCompra.Month == mes && pasaje.FechaCompra.Day == dia)
                {
                    listado += "_______________________._________________" + " \n" + pasaje.ToString() + " \n";
                }
            }

            return listado;
        }
    }
}
