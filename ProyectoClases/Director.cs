using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director:Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR");
            this.SalarioMinimo = SalarioMinimo + 200;
        }

        public override int GetDiasVacaciones()
        {
            Debug.WriteLine("Get vacaciones DIRECTOR");
            int vacacionesEmpleado = base.GetDiasVacaciones();
            return vacacionesEmpleado + 8;
        }

        public int GetDiasVacaciones(int extras)
        {
            return this.GetDiasVacaciones() + extras;
        }
    }
}
