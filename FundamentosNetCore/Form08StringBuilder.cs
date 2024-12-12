using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnIvertir_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longitud = cadena.Length;
            krono.Start();
            for (int i = 0;i<cadena.Length;i++)
            {
                //recuperamos la ultima letra
                char letra = cadena[longitud - 1];
                //eliminamos la ultima letra
                cadena = cadena.Remove(longitud - 1, 1);
                //insertamos la letra en la posicion del bucle
                cadena = cadena.Insert(i, letra.ToString());
            }
            krono.Stop();
            this.lblTiempo.Text = "Segundos : " +  krono.Elapsed.Seconds
                + " ,Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena;
        }

        private void btnInvertirBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            StringBuilder cadena = new StringBuilder();
            cadena.Append(this.txtTexto.Text);
            int longitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < cadena.Length; i++)
            {
                char letra = cadena[longitud - 1];
                cadena = cadena.Remove(longitud - 1, 1);
                cadena = cadena.Insert(i, letra.ToString());
            }
            krono.Stop();
            this.lblTiempo.Text = "Segundos : " + krono.Elapsed.Seconds
                + " ,Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena.ToString();
        }
    }
}
