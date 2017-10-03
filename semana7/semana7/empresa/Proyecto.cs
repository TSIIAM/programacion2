using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Proyecto
    {
        private DateTime fechaComienzo;
        private string nombre;
        private Cliente cliente;
        private string gerente;
        private List<Tarea> tareas = new List<Tarea>();
    }
}
