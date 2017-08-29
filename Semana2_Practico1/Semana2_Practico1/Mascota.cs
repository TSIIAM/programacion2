using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Practico1
{
    class Mascota
    {
        #region Atributos
        private string tipo;
        private decimal precio;
        private string nombre;
        private int codigo = 0;
        #endregion
        #region get-set
        public string Tipo
        {
            get
            {
                return tipo;
            }
            set{
                tipo = value;
            }

        }
        public decimal Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }

        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }

        }
        public int Codigo
        {
            get
            {
                return codigo;
            }
           

        }
        #endregion

        #region metodos
        public void modificarAtributos(string tipo, decimal precio, string nombre)
        {
            this.tipo = tipo;
            this.precio = precio;
            this.nombre = nombre;
            this.codigo = this.codigo + 1;
        }
        public void mostrarMascota()
        {
            Console.WriteLine("La mascota es un " + this.Tipo);
            Console.WriteLine("La mascota se llama " + this.Nombre);
            Console.WriteLine("La mascota   cuesta " + this.Precio);
        }
        public override string ToString()
        {
            return "El nombre es " + this.nombre + "\n" +
                    "El codigo es " + this.Tipo + "\n" +
                    "El nombre es " + this.Precio + "\n" +
                    "El codigo es " + this.Codigo;
        }
        #endregion


    }
    
}
