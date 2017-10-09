using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoSemana7_Dominio
{
    class Simple : Tarea
    {
        private int duracionEstimada;

        public Simple(string descripcion, DateTime fechaComienzo, EnumEstado estado, string usuario, int duracionEstimada) : base(descripcion, fechaComienzo, estado, usuario)
        {
            this.duracionEstimada = duracionEstimada;
        }
    }
}
