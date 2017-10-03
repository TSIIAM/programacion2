using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaDominio
{
   public class Presupuestado:Funcionario
    {
        private int anioingreso;
        private static double montoFijo = 120;

        public Presupuestado(string nombre, double sueldo, DateTime fechaNacimiento, string documento, int carnetSalud, Cargo miCargo,
            int anioingreso):base(nombre, sueldo, fechaNacimiento, documento, carnetSalud, miCargo)
        {
            this.anioingreso = anioingreso;
        }

        public override string ToString()
        {
            return base.ToString() + "El anio de ingreso es " + this.anioingreso;
        }
        public override void CalcularSueldo()
        {
            this.Sueldo = base.ObtenerSalarioCargo();
            if(this.anioingreso>DateTime.Now.Year - 4) {
                this.Sueldo += Presupuestado.montoFijo;
                    
                    }
            else
            {
                this.Sueldo += Sueldo * 1.10;
            }
            
        }
    }
}
