namespace FundamentosNetCore
{
    partial class Form07SumarNumeros
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
            btnSumar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(67, 42);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 0;
            label1.Text = "Introduzca Números";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(67, 73);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(115, 23);
            txtNumeros.TabIndex = 1;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(67, 111);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(115, 37);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar Numeros";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.Location = new Point(67, 174);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(52, 21);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label2";
            // 
            // Form07SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 269);
            Controls.Add(lblResultado);
            Controls.Add(btnSumar);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form07SumarNumeros";
            Text = "Form07SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Button btnSumar;
        private Label lblResultado;
    }
}