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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int valorX = int.Parse(this.txtPosicionX.Text);
            int valorY = int.Parse(this.txtPosicionY.Text);
            this.btnPosicion.Location = new Point(valorX, valorY);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int red = int.Parse(this.txtRojo.Text);
            int blue = int.Parse(this.txtAzul.Text);
            int green = int.Parse(this.txtVerde.Text);
            this.BackColor = Color.FromArgb(red, green, blue);

        }
    }
}
