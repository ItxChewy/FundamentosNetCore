using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form10ValidarDni : Form
    {
        public Form10ValidarDni()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string dni = this.txtDni.Text;
            string dniSinLetra = dni.Remove(dni.Length-1).ToLower();
            string letraActual = dni.Substring(dni.Length - 1);
            string letraObtenida;
            string[] valores = { "t","r", "w" , "a" ,
                "g" , "m" ,"y" , "f" ,
                "p" , "d", "x" , "b" ,
                "n" , "j" , "z" , "s",
                "q","v","h","l",
                "c", "k", "e","t"};

            int resultado = int.Parse(dniSinLetra) - ((int.Parse(dniSinLetra) / 23) * 23);

            if (letraActual == valores[resultado]) 
            {
                this.lblResultado.Text = "DNI CORRECTO";
            }
            else
            {
                this.lblResultado.Text = "Incorrecto, su letra es: " + valores[resultado];
            }

           
            
        }
    }
}
