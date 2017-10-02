using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaDominio
{
    public class Empresa
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();
        private List<Cargo> cargos = new List<Cargo>();
        private long rut;
        private string razonSocial;
        private List<Categoria> categorias = new List<Categoria>();

        public Empresa(long rut, string razonSocial)
        {
            this.rut = rut;
            this.razonSocial = razonSocial;
            this.CargarDatosPrueba();
        }

        #region Funcionarios
        //metodo que retorna un bool , busca si existe un funcionario con el documento recibido por parametro
        //busca el cargo , si el cargo y no existe un funcionario con ese documento 
        //instancia un nuevo objeto Contratado
        //agrega esta instancia a la lista de funcionarios
        public bool altaFuncionarioContratado(string nombre, double sueldo, DateTime fechaNacimiento, string documento,
            int carnetSalud, string nombreCargo, DateTime fechaContrato, int mesesDuracionContrato)
        {
            bool alta = false;
            Funcionario f = this.buscarFuncionario(documento);
            Cargo c = this.buscarCargo(nombreCargo);
            if (c != null && f==null)
            {
                funcionarios.Add(new Contratado(nombre, sueldo, fechaNacimiento, documento, carnetSalud, c, fechaContrato, mesesDuracionContrato));
                alta = true;
            }
            return alta;
        }
        //metodo que retorna un bool , busca si existe un funcionario con el documento recibido por parametro
        //busca el cargo , si el cargo y no existe un funcionario con ese documento 
        //instancia un nuevo objeto Presupuestado
        //agrega esta instancia a la lista de funcionarios
        public bool altaFuncionarioPresupuestado(string nombre, double sueldo, DateTime fechaNacimiento, string documento,
           int carnetSalud, string nombreCargo, int anioIngreso)
        {
            bool alta = false;
            Funcionario f = this.buscarFuncionario(documento);
            Cargo c = this.buscarCargo(nombreCargo);
            if (c != null && f==null)
            {
                funcionarios.Add(new Presupuestado(nombre, sueldo, fechaNacimiento, documento, carnetSalud, c, anioIngreso));
                alta = true;
            }
            return alta;
        }
        //metodo que busca si existe un Funcionario con el documento recibido por parametro
        public Funcionario buscarFuncionario(string documento)
        {
            Funcionario funcionario = null;
            int i = 0;
            bool bandera = false;

            while (i < funcionarios.Count && !bandera)
            {
                if (funcionarios[i].Documento == documento)
                {
                    funcionario = funcionarios[i];
                    bandera = true;
                }
                i++;
            }
            return funcionario;
        }

       //metodo que retorna la lista de funcionarios que tienen el cargo recibido por parametro
        public string listadoFuncionariosXCargo(string nombreCargo)
        {
            string listadoFuncionarios = "";
            Cargo c = this.buscarCargo(nombreCargo);
            foreach(Funcionario f in funcionarios)
            {
                if (f.MiCargo.Equals(c))
                {
                    listadoFuncionarios += f.ToString() + "\n";
                }
            }
            return listadoFuncionarios;
        }
        //metodo que aumenta el sueldos de los funcionarios que tiene la categoria Sistemas.
        //busca si existe una instancia de la clase Categoria con la descripcion Sistemas, 
        //recorre los funcionarios y por cada funcionario 
        //llama al metodo tieneCategoria pasando esa categoria por parametro
        //si el metodo en funcionario retorna verdadero modifica el sueldo del funcionario
        public bool aumentoSueldos()
        {
            bool aumento = false;
            Categoria c = this.buscarCategoria("Sistemas");
            if (c != null) { 
            foreach (Funcionario f in funcionarios)
            {
                if (f.tieneCategoria(c))
                {
                    f.Sueldo = f.Sueldo * 1.10;
                    aumento = true;
                }
            }
        }
            return aumento;
        }

        public string listadoFuncionariosAumento()
        {
            string listadoFuncionarios = "";
            Categoria c = this.buscarCategoria("Sistemas");
            if (c != null)
            {
                foreach (Funcionario f in funcionarios)
                {
                    if (f.tieneCategoria(c))
                    {
                        listadoFuncionarios += f.ToString() + "\n";
                    }
                }
            }
            return listadoFuncionarios;
        }
        #endregion
        #region Categoria
        //metodo que permite dar de alta una Categoria si ya no existe una categoria con esa descripcion
        public bool altaCategoria(string descripcion){
            bool alta = false;
            if (this.buscarCategoria(descripcion) == null)
            {
                Categoria c = new Categoria(descripcion);
                categorias.Add(c);
                alta = true;
            }
            return alta;
        }

        //metodo que busca si existe una categoria con la descripcion que recibe por parametros, si la misma existe
        //asigna la referencia de ese objeto a la variable c
        public Categoria buscarCategoria(string descripcion)
        {
            Categoria c = null;
            bool bandera = false;
            int i = 0;
            while(i<categorias.Count && !bandera)
            {
                if (categorias[i].Descripcion == descripcion)
                {
                    bandera = true;
                    c = categorias[i];
                }
                    i++;
            }
                return c;
        }
        #endregion

        #region Cargo 
        public void AltaCargo(string nombre, int salario, string descripcion)
        {
            Categoria categoria = this.buscarCategoria(descripcion);
            if (categoria != null)
            {
                this.cargos.Add(new Cargo(nombre, salario, categoria));
            }
        }
        //metodo que permite buscar si existe un Cargo con el nombre de cargo que se recibe por parametro
        public Cargo buscarCargo(string nombreCargo)
        {
            Cargo c = null;
            int i = 0;
            bool bandera = false;

            while (i < cargos.Count && !bandera)
            {
                if (cargos[i].Nombre == nombreCargo)
                {
                    c = cargos[i];
                    bandera = true;
                }
                i++;
            }
            return c;
        }
        //metodo que retorna un string con los datos de los cargos
        public string mostrarCargos()
        {
            string datosCargos = "";
            foreach (Cargo c in cargos)
            {
                datosCargos += c.ToString() + "\n";
            }
            return datosCargos;
        }
        #endregion
        public void CargarDatosPrueba()
        {
            this.altaCategoria("Sistemas");
            this.altaCategoria("Administracion");
            this.AltaCargo("Desarrollador", 25000,"Sistemas");
            this.AltaCargo("Programador", 25000,"Administracion");
            this.AltaCargo("Ingeniero", 40000,"Sistemas");
            
        }
    }
}
