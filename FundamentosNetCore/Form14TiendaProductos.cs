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
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            this.lstTienda.SelectedItem = "";
            string producto = this.txtProducto.Text.ToUpper();
            int contador = 0;
            for (int i = 0; i < this.lstTienda.Items.Count; i++)
            {
                if (producto != this.lstTienda.Items[i].ToString())
                {
                    contador++;
                }
                else
                {
                    this.lstTienda.SelectedItem = this.lstTienda.Items[i];
                }
            }
            if (contador == this.lstTienda.Items.Count)
            {
                this.lstTienda.Items.Add(producto);
            }

        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnEliminarTodosProductos_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                string producto = this.lstTienda.SelectedItems[i].ToString();
                this.lstAlmacen.Items.Add(producto);
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index - 1, producto);
            this.lstAlmacen.SelectedIndex = index - 1;

        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index + 1, producto);
            this.lstAlmacen.SelectedIndex = index + 1;
        }
    }
}
