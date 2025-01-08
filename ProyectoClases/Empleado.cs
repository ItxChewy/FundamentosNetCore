using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        protected int SalarioMinimo { get; set; }
        public Empleado()
        {
            Debug.WriteLine("Constructor Empleado vacío");
            this.SalarioMinimo = 1400;
        }

        public Empleado(string nombre, string apellido)
        {
            Debug.WriteLine("Constructor EMPLEADO 2 parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellido;
        }

        #region METODOS
        public int GetSlarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("get vacaciones empleado");
            return 22;
        }
        #endregion

    }
}
