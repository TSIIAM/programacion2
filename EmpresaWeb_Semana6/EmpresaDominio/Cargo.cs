using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaDominio
{
    public class Cargo
    {
        private string nombre;
        private int salario;
        private Categoria categoria;

        public string Nombre
        {
            get { return nombre; }
        }
        public int Salario
        {
            get{ return this.salario; }
        }
        public Cargo(string nombre, int salario, Categoria categoria)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.categoria = categoria;
        }

        public Categoria Categoria
        {
            get { return this.categoria; }
        }
        public override string ToString()
        {
            return "El nombre del cargo es" + this.nombre + "-" + "El salario del cargo es " + this.salario;
        }

        //metodo que retorna verdadero si el cargo tiene la misma categoria que la que se recibe por parametro 
        public bool tieneCategoria(Categoria c)
        {
            bool tiene = false;
            if (categoria==c)
            {
                tiene = true;
            }
            return tiene;
        }
    }
}
