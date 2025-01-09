namespace FundamentosNetCore
{
    partial class Form24ColeccionXMLMascotas
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
            btnGuardarMascotas = new Button();
            btnLeerMascotas = new Button();
            lstMascotas = new ListBox();
            Mascotas = new Label();
            btnNuevaMascota = new Button();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtAnio = new TextBox();
            SuspendLayout();
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(56, 356);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(100, 42);
            btnGuardarMascotas.TabIndex = 17;
            btnGuardarMascotas.Text = "Guardar mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(56, 304);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(100, 35);
            btnLeerMascotas.TabIndex = 16;
            btnLeerMascotas.Text = "Leer mascota";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(355, 75);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(254, 334);
            lstMascotas.TabIndex = 15;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Mascotas
            // 
            Mascotas.AutoSize = true;
            Mascotas.Location = new Point(355, 44);
            Mascotas.Name = "Mascotas";
            Mascotas.Size = new Size(57, 15);
            Mascotas.TabIndex = 14;
            Mascotas.Text = "Mascotas";
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(56, 250);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(100, 37);
            btnNuevaMascota.TabIndex = 13;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(56, 144);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 116);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 11;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(56, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 175);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 18;
            label3.Text = "Años";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(56, 193);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 19;
            // 
            // Form24ColeccionXMLMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 453);
            Controls.Add(txtAnio);
            Controls.Add(label3);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(btnLeerMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(Mascotas);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form24ColeccionXMLMascotas";
            Text = "Form24ColeccionXMLMascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarMascotas;
        private Button btnLeerMascotas;
        private ListBox lstMascotas;
        private Label Mascotas;
        private Button btnNuevaMascota;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private TextBox txtAnio;
    }
}