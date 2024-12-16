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
    public partial class Form12ColeccionMultiple : Form
    {
        public Form12ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevoElemento.Focus();
            this.txtNuevoElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ",";
            }
            this.lblIndexSeleccionado.Text = indices.Trim(',');
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ",";
            }
            this.lblItemsSeleccionado.Text = items.Trim(',');
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for(int i = this.lstElementos.SelectedIndices.Count -1; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }
    }
}
