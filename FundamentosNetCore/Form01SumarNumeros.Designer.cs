namespace FundamentosNetCore
{
    partial class Form01SumarNumeros
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
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSumarNumeros = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(49, 78);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(49, 227);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 60);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 209);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Numero 2";
            // 
            // btnSumarNumeros
            // 
            btnSumarNumeros.Location = new Point(248, 135);
            btnSumarNumeros.Name = "btnSumarNumeros";
            btnSumarNumeros.Size = new Size(114, 42);
            btnSumarNumeros.TabIndex = 4;
            btnSumarNumeros.Text = "button1";
            btnSumarNumeros.UseVisualStyleBackColor = true;
            btnSumarNumeros.Click += btnSumarNumeros_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14F);
            lblResultado.ForeColor = Color.Fuchsia;
            lblResultado.Location = new Point(37, 322);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(94, 25);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 495);
            Controls.Add(lblResultado);
            Controls.Add(btnSumarNumeros);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label label1;
        private Label label2;
        private Button btnSumarNumeros;
        private Label lblResultado;
    }
}