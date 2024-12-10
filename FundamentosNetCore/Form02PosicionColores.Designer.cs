namespace FundamentosNetCore
{
    partial class Form02PosicionColores
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
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            btnPosicion = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnColor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 41);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Posicion X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 95);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Posicion Y :";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(54, 59);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 23);
            txtPosicionX.TabIndex = 2;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(51, 120);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 23);
            txtPosicionY.TabIndex = 3;
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(234, 82);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(132, 31);
            btnPosicion.TabIndex = 4;
            btnPosicion.Text = "Cambiar Posicion";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 218);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 293);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 364);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 7;
            label5.Text = "Azul";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(46, 236);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 8;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(46, 311);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 9;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(46, 396);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 10;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(234, 293);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(123, 30);
            btnColor.TabIndex = 11;
            btnColor.Text = "Cambiar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 599);
            Controls.Add(btnColor);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnPosicion);
            Controls.Add(txtPosicionY);
            Controls.Add(txtPosicionX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02PosicionColores";
            Text = "Form2PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private Button btnPosicion;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnColor;
    }
}