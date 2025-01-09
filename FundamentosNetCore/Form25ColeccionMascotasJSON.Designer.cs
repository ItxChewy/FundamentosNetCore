namespace FundamentosNetCore
{
    partial class Form25ColeccionMascotasJSON
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
            txtAnio = new TextBox();
            label3 = new Label();
            btnGuardarMascotas = new Button();
            btnLeerMascotas = new Button();
            lstMascotas = new ListBox();
            Mascotas = new Label();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            btnNuevaMascota = new Button();
            SuspendLayout();
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(124, 192);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 174);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 29;
            label3.Text = "Años";
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(124, 355);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(100, 42);
            btnGuardarMascotas.TabIndex = 28;
            btnGuardarMascotas.Text = "Guardar mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(124, 303);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(100, 35);
            btnLeerMascotas.TabIndex = 27;
            btnLeerMascotas.Text = "Leer mascota";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(423, 74);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(254, 334);
            lstMascotas.TabIndex = 26;
            // 
            // Mascotas
            // 
            Mascotas.AutoSize = true;
            Mascotas.Location = new Point(423, 43);
            Mascotas.Name = "Mascotas";
            Mascotas.Size = new Size(57, 15);
            Mascotas.TabIndex = 25;
            Mascotas.Text = "Mascotas";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(124, 143);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 115);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 22;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 20;
            label1.Text = "Nombre";
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(124, 250);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(100, 34);
            btnNuevaMascota.TabIndex = 31;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click_1;
            // 
            // Form25ColeccionMascotasJSON
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 462);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtAnio);
            Controls.Add(label3);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(btnLeerMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(Mascotas);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form25ColeccionMascotasJSON";
            Text = "Form25ColeccionMascotasJSON";
         
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnio;
        private Label label3;
        private Button btnGuardarMascotas;
        private Button btnLeerMascotas;
        private ListBox lstMascotas;
        private Label Mascotas;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Button btnNuevaMascota;
    }
}