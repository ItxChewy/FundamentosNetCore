namespace FundamentosNetCore
{
    partial class Form05Char
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
            txtNumeros = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLetras = new TextBox();
            txtSimbolos = new TextBox();
            txtPuntuacion = new TextBox();
            btnRun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Numeros";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(23, 61);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(165, 125);
            txtNumeros.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(360, 28);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 2;
            label2.Text = "Letras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(23, 231);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 3;
            label3.Text = "Símbolos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(360, 215);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 4;
            label4.Text = "Puntuacion";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(360, 61);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(165, 125);
            txtLetras.TabIndex = 5;
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(23, 259);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(165, 125);
            txtSimbolos.TabIndex = 6;
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(360, 259);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(165, 125);
            txtPuntuacion.TabIndex = 7;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(225, 396);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(107, 41);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 492);
            Controls.Add(btnRun);
            Controls.Add(txtPuntuacion);
            Controls.Add(txtSimbolos);
            Controls.Add(txtLetras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLetras;
        private TextBox txtSimbolos;
        private TextBox txtPuntuacion;
        private Button btnRun;
    }
}