using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaDominio
{
   public class Funcionario
    {
        private string nombre;
        private double sueldo;
        private DateTime fechaNacimiento;
        private string documento;
        private int carnetSalud;
        private Cargo miCargo;

        public Cargo MiCargo
        {
            get { return miCargo; }
        }

        public string Documento
        {
            get { return documento; }
        }
        public double Sueldo
        {
            get { return this.sueldo; }
            set { this.sueldo = value; }
        }
        public Funcionario(string nombre, double sueldo, DateTime fechaNacimiento, string documento, int carnetSalud, Cargo miCargo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
            this.fechaNacimiento = fechaNacimiento;
            this.documento = documento;
            this.carnetSalud = carnetSalud;
            this.miCargo = miCargo;
        }
        public override string ToString()
        {
            return "El nombre del funcionario es " + this.nombre + "-" + "El sueldo del funcionario es" + this.sueldo
                + "El nombre del cargo es" + this.miCargo.Nombre;
        }
        
        //llama al método tieneCategoria en la clase Cargo
        public bool tieneCategoria(Categoria c)
        {
            bool tiene = false;
            if (this.miCargo.tieneCategoria(c))
            {
                tiene = true;
            }
            return tiene;
        }
        public double ObtenerSalarioCargo()
        {
            double salario = 0;
            salario = this.miCargo.Salario;
            return salario;
        }
        public virtual void CalcularSueldo()
        {
            this.sueldo = this.ObtenerSalarioCargo();
        }

    }
}
