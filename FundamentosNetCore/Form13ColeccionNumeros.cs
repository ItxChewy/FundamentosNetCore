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
    public partial class Form13ColeccionNumeros : Form
    {
        public Form13ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                int numeroAleatorio = random.Next(0, 10);
                this.lstNumeros.Items.Add(numeroAleatorio);
            }


        }

        private void btnMostarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            for(int i =0; i< this.lstNumeros.Items.Count; i++)
            {
                int selectedItemValue = (int)this.lstNumeros.Items[i];
                suma += selectedItemValue;
                if(selectedItemValue%2 == 0)
                {
                    sumaPares += selectedItemValue;
                }
                else
                {
                    sumaImpares += selectedItemValue;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();

        }
    }
}
