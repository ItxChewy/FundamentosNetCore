namespace FundamentosNetCore
{
    partial class Form21Files
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
            label1 = new Label();
            txtContenido = new TextBox();
            Nombre = new Label();
            txtNombre = new TextBox();
            btnNuevoNombre = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            Nombres = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 17);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(12, 35);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(211, 260);
            txtContenido.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(300, 17);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(276, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(276, 80);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(100, 46);
            btnNuevoNombre.TabIndex = 4;
            btnNuevoNombre.Text = "Nuevo Nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(276, 152);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(100, 32);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(276, 213);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(100, 36);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // Nombres
            // 
            Nombres.AutoSize = true;
            Nombres.Location = new Point(462, 17);
            Nombres.Name = "Nombres";
            Nombres.Size = new Size(56, 15);
            Nombres.TabIndex = 7;
            Nombres.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(443, 36);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(185, 259);
            lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 307);
            Controls.Add(lstNombres);
            Controls.Add(Nombres);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Controls.Add(txtContenido);
            Controls.Add(label1);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenido;
        private Label Nombre;
        private TextBox txtNombre;
        private Button btnNuevoNombre;
        private Button btnRead;
        private Button btnWrite;
        private Label Nombres;
        private ListBox lstNombres;
    }
}