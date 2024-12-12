namespace FundamentosNetCore
{
    partial class Form09Isbn
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
            btnValidar = new Button();
            label1 = new Label();
            txtIsbn = new TextBox();
            lblRespuesta = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Segoe UI", 10F);
            btnValidar.Location = new Point(100, 139);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(144, 39);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar ISBN";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(76, 49);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 1;
            label1.Text = "Introduzca ISBN";
            // 
            // txtIsbn
            // 
            txtIsbn.Font = new Font("Segoe UI", 16F);
            txtIsbn.Location = new Point(76, 85);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(298, 36);
            txtIsbn.TabIndex = 2;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI", 16F);
            lblRespuesta.Location = new Point(76, 224);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(71, 30);
            lblRespuesta.TabIndex = 3;
            lblRespuesta.Text = "label2";
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 492);
            Controls.Add(lblRespuesta);
            Controls.Add(txtIsbn);
            Controls.Add(label1);
            Controls.Add(btnValidar);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private Label label1;
        private TextBox txtIsbn;
        private Label lblRespuesta;
    }
}