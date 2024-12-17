using System;
using System.Collections;
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
    public partial class Form16ArrayList : Form
    {
        public Form16ArrayList()
        {
            InitializeComponent();

            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1);
            ((Button)coleccion[0]).BackColor = Color.Yellow;
            foreach(Control miControl in coleccion)
            {
                miControl.BackColor = Color.LightCoral;
                if(miControl is TextBox)
                {
                    ((TextBox)miControl).Paste();
                }
            }
        }
    }
}
