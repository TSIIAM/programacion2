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
  
        public Proyecto(DateTime fechaComienzoP, string nombreProyecto, Cliente cliente, string gerenteProyecto, string descripcion, DateTime fechaComienzoT, EnumEstado estado, string usuario, int duracionEstimada)
        {
            this.fechaComienzo = fechaComienzoP;
            this.nombreProyecto = nombreProyecto;
            this.cliente = cliente;
            this.gerenteProyecto = gerenteProyecto;
            //Agregar tarea aca
            Tarea tarea = new Simple(descripcion, fechaComienzoT, estado, usuario, duracionEstimada);
            tareas.Add(tarea);
        }
        
        public void AgregarTarea(string descripcion, DateTime fechaComiezoT)
        {

        }
    }
}
