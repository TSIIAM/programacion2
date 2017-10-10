using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoSemana7_Dominio
{
    public class Proyecto
    {
        private DateTime fechaComienzo;
        private string nombreProyecto;
        private Cliente cliente;
        private string gerenteProyecto;
        private List<Tarea> tareas = new List<Tarea>();
        public string Gerente
        {
            get { return gerenteProyecto; }
        }
        public List<Tarea> Tareas
        {
            get { return tareas; }
        }

        public Proyecto(DateTime fechaComienzo, string nombreProyecto, Cliente cliente, string gerenteProyecto )
        {
            this.fechaComienzo = fechaComienzo;
            this.nombreProyecto = nombreProyecto;
            this.cliente = cliente;
            this.gerenteProyecto = gerenteProyecto;
            
        }


        public void AgregarTarea(Tarea tarea)
        {
            this.tareas.Add(tarea);
        }

        public override string ToString()
        {
            return "Nombre Proyecto: " + this.nombreProyecto + "  Cliente:  " + this.cliente.RazonSocial + " Gerenge de Proyecto  : " + this.gerenteProyecto;

        }

    }
}
