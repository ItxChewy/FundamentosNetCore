using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace FundamentosNetCore
{
    public partial class Form21Files : Form
    {
        private string Path { get; set; }
        private HelperFiles helper;
        public Form21Files()
        {
            InitializeComponent();
            this.helper = new HelperFiles();
            //this.Path = @"C:\carpeta\file1.txt";
            this.Path = "file1.txt";
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            string data = this.GetNombresListBox();
            await HelperFiles.WriteFileAsync(this.Path,data);
            MessageBox.Show("Datos guardados");

        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            string data = await HelperFiles.ReadFileAsync(this.Path);
            
            this.txtContenido.Text = data;
        }
    }
}
