using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoSemana7_Dominio
{
    public class Empresa
    {
        private List<Proyecto> proyectos = new List<Proyecto>();
        private List<Cliente> clientes = new List<Cliente>();

        public Empresa()
        {
            
            GenerarDatosPrueba();
             
        }

        public void GenerarDatosPrueba()
        {
            AltaCliente("Wunderer", "26055487", "Mercedes 2020", "Rolando");
            AltaCliente("Maxim", "26047898", "Colonia 1045", "Hernan");
         
            AltaProyecto(new DateTime(2017, 10, 9, 18, 50, 30), "Data Warehouse", "Wunderer", "Ramon Ortiz");
            AltaProyecto(new DateTime(2017, 10, 6, 15, 30, 30), "Data Driven Development", "Maxim", "Gabriel Ortiz");
            AltaProyecto(new DateTime(2017, 10, 5, 17, 40, 30), "E-Commerce Website", "Maxim", "Gabriel Ortiz");

        }
        #region Cliente
        public bool AltaCliente(string razonSocial, string telefono, string direccion, string nombreContacto)
        {
            bool dioAlta;
            Cliente existeCliente = BuscarCliente(razonSocial);
            if (existeCliente == null)
            {

                Cliente nuevoCliente = new Cliente(razonSocial, telefono, direccion, nombreContacto);
                clientes.Add(nuevoCliente);
                dioAlta = true;
                return dioAlta;
            }
            dioAlta = false;
            return dioAlta;
        }
        public Cliente BuscarCliente(string razonSocial)
        {
            Cliente existeCliente = null;

            foreach (Cliente client in clientes)
            {
                if (client.RazonSocial == razonSocial)
                {
                    existeCliente = client;

                }
            }
            return existeCliente;

        }
        public string ListarClientes()
        {
            string listadoClientes = "";

            foreach (Cliente cliente in clientes)
            {
                listadoClientes += "_________________________________" + " \n" + cliente.ToString() + " \n";
            }

            return listadoClientes;
        }
        #endregion
        public bool AltaTareaSimple(Proyecto proyecto, string descripcion, DateTime fechaComienzo, EnumEstado estado,string usuario, int duracionEstimada)
        {
            bool dioAlta;
            Tarea existeTarea = BuscarTarea(proyecto,descripcion);
            if (existeTarea == null)
            {

                Simple nuevaTareaSimple = new Simple(descripcion,fechaComienzo,estado,usuario,duracionEstimada);
                proyecto.AgregarTarea(nuevaTareaSimple);
                dioAlta = true;
                return dioAlta;
            }
            dioAlta = false;
            return dioAlta;

        }
        public Tarea BuscarTarea(Proyecto proyecto , string descripcion)
        {
            Proyecto existeProyecto = BuscarProyecto(proyecto.Gerente);
            Tarea existeTarea = null;

            if (existeProyecto != null) {
                

                for (int i = 0; i < proyecto.Tareas.Count; i++)
                {
                    if (proyecto.Tareas[i].Descripcion == descripcion)
                    {
                        existeTarea = proyecto.Tareas[i];
                    }
                }
                return existeTarea;

            }
            return existeTarea;
        }

        #region Proyecto
        public bool AltaProyecto(DateTime fechaComienzo, string nombreProyecto, string razonSocial,string gerenteProyecto)
        {
            bool dioAlta;
            Cliente existeCliente = BuscarCliente(razonSocial);
            if (existeCliente != null)
            {
                Proyecto existeProyecto = BuscarProyecto(gerenteProyecto);
                if (existeProyecto == null)
                {
                    Proyecto nuevoProyecto = new Proyecto(fechaComienzo, nombreProyecto, existeCliente, gerenteProyecto);
                    proyectos.Add(nuevoProyecto);
                    dioAlta = true;
                    return dioAlta;
                }
                
            }
            dioAlta = false;
            return dioAlta;

        }
        public Proyecto BuscarProyecto(string gerente)
        {
            Proyecto existeProyecto = null;
            foreach (Proyecto proyecto in proyectos)
            {
                if (proyecto.Gerente == gerente)
                {
                    existeProyecto = proyecto;

                }
            }
            return existeProyecto;


        }
        public string ListarProyectos()
        {
            string listadoProyectos = "";

            foreach (Proyecto proyecto in proyectos)
            {
                listadoProyectos += "_________________________________" + " \n" + proyecto.ToString() + " \n";
            }

            return listadoProyectos;

        }
        #endregion
    }


}
