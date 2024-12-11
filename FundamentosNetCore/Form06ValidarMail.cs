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
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mail = this.txtMail.Text;
            string trimeado = mail.Replace("@","aa");
            //int ultimo = mail.Length -1;
            //char car = mail[ultimo];
            if (mail.IndexOf("@") == -1)
            {
                this.lblResultados.Text = "Falta el @";
            }
            else if (mail[0] == '@' || mail[mail.Length - 1] == '@')
            {
                this.lblResultados.Text = "No puede empezar y/o acabar en @";
            } else if (trimeado.Length - 1  != mail.Length) {
                this.lblResultados.Text = "No puede haber 2 o mas  @";
            } else if (!mail.Contains(".")) {
                this.lblResultados.Text = "Debe de contener un .";

            } else if (mail.IndexOf("@.") == -1) {
                this.lblResultados.Text = "El . debe de ir despues del @";
            } else if (mail.Length - 1 - mail.LastIndexOf(".") < 2 || mail.Length - 1 - mail.LastIndexOf(".") > 4)
            {
                this.lblResultados.Text = "El dominio debe de ser de 2 a 4 caracteres";
            }
            else
            {
                this.lblResultados.Text = "todo correcto";
            }

        }
    }
}
