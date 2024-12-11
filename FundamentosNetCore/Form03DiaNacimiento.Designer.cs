namespace FundamentosNetCore
{
    partial class Form03DiaNacimiento
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
            label2 = new Label();
            label3 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnio = new TextBox();
            btnCalcularDiaNacimiento = new Button();
            lblDiaNacimiento = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 38);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 125);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 219);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(78, 74);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(78, 152);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 4;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(78, 253);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 5;
            // 
            // btnCalcularDiaNacimiento
            // 
            btnCalcularDiaNacimiento.Location = new Point(312, 125);
            btnCalcularDiaNacimiento.Name = "btnCalcularDiaNacimiento";
            btnCalcularDiaNacimiento.Size = new Size(141, 62);
            btnCalcularDiaNacimiento.TabIndex = 6;
            btnCalcularDiaNacimiento.Text = "Calcular dia nacimiento";
            btnCalcularDiaNacimiento.UseVisualStyleBackColor = true;
            btnCalcularDiaNacimiento.Click += btnCalcularDiaNacimiento_Click;
            // 
            // lblDiaNacimiento
            // 
            lblDiaNacimiento.AutoSize = true;
            lblDiaNacimiento.Font = new Font("Segoe UI", 30F);
            lblDiaNacimiento.ForeColor = Color.FromArgb(192, 0, 0);
            lblDiaNacimiento.Location = new Point(75, 343);
            lblDiaNacimiento.Name = "lblDiaNacimiento";
            lblDiaNacimiento.Size = new Size(130, 54);
            lblDiaNacimiento.TabIndex = 7;
            lblDiaNacimiento.Text = "label4";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 460);
            Controls.Add(lblDiaNacimiento);
            Controls.Add(btnCalcularDiaNacimiento);
            Controls.Add(txtAnio);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnio;
        private Button btnCalcularDiaNacimiento;
        private Label lblDiaNacimiento;
    }
}