using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FundamentosNetCore
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcularDiaNacimiento_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anio = int.Parse(this.txtAnio.Text);
            if (mes == 1)
            {
                mes = 13;
                anio = anio - 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                anio = anio - 1;
            }

            //double prueba = 6.7;
            //int parseado = (int)prueba;

            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anio / 4;
            int op3 = anio / 100;
            int op4 = anio / 400;
            int op5 = dia + (mes * 2) + anio + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);

            switch (resultado)
            {
                case 0:
                    this.lblDiaNacimiento.Text = "Sábado";
                    break;
                case 1:
                    this.lblDiaNacimiento.Text = "Domingo";
                    break;
                case 2:
                    this.lblDiaNacimiento.Text = "Lunes";
                    break;
                case 3:
                    this.lblDiaNacimiento.Text = "Martes";
                    break;
                case 4:
                    this.lblDiaNacimiento.Text = "Miercoles";
                    break;
                case 5:
                    this.lblDiaNacimiento.Text = "Jueves";
                    break;
                case 6:
                    this.lblDiaNacimiento.Text = "Viernes";
                    break;
            }

            //DateTime fecha = new DateTime(anio, mes, dia);

            //this.lblDiaNacimiento.Text = fecha.ToString("dddd");
        }
    }
}
