﻿namespace FundamentosNetCore
{
    partial class Form10ValidarDni
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
            txtDni = new TextBox();
            btnValidar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(11, 33);
            label1.Name = "label1";
            label1.Size = new Size(158, 30);
            label1.TabIndex = 0;
            label1.Text = "Introduzca DNI";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 12F);
            txtDni.Location = new Point(12, 76);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(250, 29);
            txtDni.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(119, 128);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(105, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar DNI";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 16F);
            lblResultado.Location = new Point(26, 214);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(71, 30);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label2";
            // 
            // Form10ValidarDni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 435);
            Controls.Add(lblResultado);
            Controls.Add(btnValidar);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Name = "Form10ValidarDni";
            Text = "Form10ValidarDni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDni;
        private Button btnValidar;
        private Label lblResultado;
    }
}