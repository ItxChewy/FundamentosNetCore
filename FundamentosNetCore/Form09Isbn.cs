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
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;
           
            if (isbn.Length != 10)
            {
                this.lblRespuesta.Text = "El ISBN debe de contener 10 caracteres";
            }
            else
            {
                int suma = 0;
                for(int i = 0; i < isbn.Length; i++)
                {
                    suma += isbn[i] * (i+1);
                }
                if(suma%11 == 0)
                {
                    this.lblRespuesta.Text = "ISBN correcto";
                }
                else
                {
                    this.lblRespuesta.Text = "ISBN incorrecto";
                }
            }
            
        }
    }
}
