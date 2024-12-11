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
            if(red <0 || red > 255)
            {
                MessageBox.Show("El valor rojo debe ser entre 0 y 255"
                    , "Mensaje de Error",MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Question);
            }
            else if(green<0 || green>255)
            {
                MessageBox.Show("El valor verde debe ser entre 0 y 255"
                    , "Mensaje de Error", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Question);
            }else if(blue<0 || blue < 255)
            {
                MessageBox.Show("El valor verde debe ser entre 0 y 255"
                   , "Mensaje de Error", MessageBoxButtons.RetryCancel,
                   MessageBoxIcon.Question);
            }
            
            this.BackColor = Color.FromArgb(red, green, blue);

        }
    }
}
