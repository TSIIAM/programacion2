using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaDominio
{
   public class Contratado:Funcionario
    {
        private DateTime fechaContrato;
        private int mesesDuracionContrato;

        public Contratado(string nombre, double sueldo, DateTime fechaNacimiento, string documento, int carnetSalud, Cargo miCargo,
            DateTime fechaContrato, int mesesDuracionContrato) : base(nombre, sueldo, fechaNacimiento, documento, carnetSalud, miCargo)
        {

            this.fechaContrato = fechaContrato;
            this.mesesDuracionContrato = mesesDuracionContrato;
        }

        public override string ToString()
        {
            return base.ToString() + "La fecha del contrato es" + this.fechaContrato;
        }

        public override void CalcularSueldo()
        {
            this.Sueldo = base.ObtenerSalarioCargo();
            if (this.mesesDuracionContrato > 12)
            {
                this.Sueldo+= this.Sueldo * 1.15;
            }
            else
            {
                this.Sueldo += this.Sueldo * 1.20;
            }
        }

    }
}
