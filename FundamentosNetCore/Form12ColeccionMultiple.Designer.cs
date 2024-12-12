namespace FundamentosNetCore
{
    partial class Form12ColeccionMultiple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIndexSeleccionado = new Label();
            lblItemSeleccionado = new Label();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtNuevoElemento = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Font = new Font("Segoe UI", 12F);
            lblIndexSeleccionado.Location = new Point(113, 359);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(52, 21);
            lblIndexSeleccionado.TabIndex = 17;
            lblIndexSeleccionado.Text = "label3";
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Font = new Font("Segoe UI", 12F);
            lblItemSeleccionado.Location = new Point(113, 316);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(149, 21);
            lblItemSeleccionado.TabIndex = 16;
            lblItemSeleccionado.Text = "lblItemSeleccionado";
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(428, 233);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(111, 24);
            btnBorrarTodo.TabIndex = 15;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(428, 189);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 24);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(128, 255, 128);
            btnInsertar.Location = new Point(428, 138);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(111, 24);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(404, 95);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(170, 23);
            txtNuevoElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(404, 71);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 11;
            label2.Text = "Nuevo Elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(103, 95);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(187, 184);
            lstElementos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(103, 60);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // Form12ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 441);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form12ColeccionMultiple";
            Text = "Form12ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndexSeleccionado;
        private Label lblItemSeleccionado;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtNuevoElemento;
        private Label label2;
        private ListBox lstElementos;
        private Label label1;
    }
}