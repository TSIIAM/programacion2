using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaDominio
{
   public class Categoria
    {
        private int codigo;
        private static int ultcodigo;
        private string descripcion;
        
        public string Descripcion
        {
            get { return this.descripcion; }
        }
        public int Codigo
        {
            get { return this.codigo; }
        }

        public Categoria(string descripcion)
        {
            this.descripcion = descripcion;
            this.codigo = Categoria.ultcodigo;
            Categoria.ultcodigo++;
        }
        public override string ToString()
        {
            return this.codigo + "-" + this.descripcion;
        }
    }
}
