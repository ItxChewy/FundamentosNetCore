namespace FundamentosNetCore
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            btnIvertir = new Button();
            btnInvertirBuilder = new Button();
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 21);
            label1.TabIndex = 0;
            label1.Text = "Copie el texto para trabajar";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(63, 59);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(404, 186);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // btnIvertir
            // 
            btnIvertir.Location = new Point(63, 304);
            btnIvertir.Name = "btnIvertir";
            btnIvertir.Size = new Size(184, 43);
            btnIvertir.TabIndex = 2;
            btnIvertir.Text = "Invertir String";
            btnIvertir.UseVisualStyleBackColor = true;
            btnIvertir.Click += btnIvertir_Click;
            // 
            // btnInvertirBuilder
            // 
            btnInvertirBuilder.Location = new Point(283, 304);
            btnInvertirBuilder.Name = "btnInvertirBuilder";
            btnInvertirBuilder.Size = new Size(184, 43);
            btnInvertirBuilder.TabIndex = 3;
            btnInvertirBuilder.Text = "Invertir StringBuilder";
            btnInvertirBuilder.UseVisualStyleBackColor = true;
            btnInvertirBuilder.Click += btnInvertirBuilder_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(72, 271);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(79, 21);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "lblTiempo";
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 405);
            Controls.Add(lblTiempo);
            Controls.Add(btnInvertirBuilder);
            Controls.Add(btnIvertir);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtTexto;
        private Button btnIvertir;
        private Button btnInvertirBuilder;
        private Label lblTiempo;
    }
}