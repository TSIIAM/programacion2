using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoSemana7_Dominio
{
    public abstract class Tarea
    {
        private string descripcion;
        private DateTime fechaComienzo;
        private EnumEstado estado;
        private string usuario;
        public string Descripcion
        {
            get { return descripcion; }
        }
        public Tarea(string descripcion, DateTime fechaComienzo, EnumEstado estado, string usuario)
        {
            this.descripcion = descripcion;
            this.fechaComienzo = fechaComienzo;
            this.estado = estado;
            this.usuario = usuario;
        }
    }
}
