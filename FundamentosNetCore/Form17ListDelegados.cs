﻿using System;
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
    public partial class Form17ListDelegados : Form
    {
        int contador;
        List<Button> botones;
        public Form17ListDelegados()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            //this.button1.Click += BotonPulsado;
           foreach(Control miControl in this.Controls)
            {
                if(miControl is Button)
                {
                    this.botones.Add((Button)miControl);
                }
            }
            foreach(Button boton in this.botones)
            {
                boton.Click += BotonPulsado;
            }

        }
        void BotonPulsado(object sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = this.contador.ToString();
            Button miBoton = (Button)sender;
            miBoton.BackColor = Color.LimeGreen;
        }
        
    }
}
