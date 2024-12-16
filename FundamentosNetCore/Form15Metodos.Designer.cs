namespace FundamentosNetCore
{
    partial class Form15Metodos
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
            lbl1 = new Label();
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDoble = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblRaton = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(31, 19);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(49, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(31, 46);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(30, 105);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "lblResultado";
            // 
            // btnDoble
            // 
            btnDoble.Location = new Point(30, 159);
            btnDoble.Name = "btnDoble";
            btnDoble.Size = new Size(75, 43);
            btnDoble.TabIndex = 3;
            btnDoble.Text = "Doble Valor";
            btnDoble.UseVisualStyleBackColor = true;
            btnDoble.Click += btnDoble_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(30, 220);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(75, 40);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(30, 287);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(75, 47);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 30);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 6;
            label1.Text = "Solo numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 118);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Solo letras";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.Lime;
            lblRaton.Location = new Point(238, 215);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(227, 124);
            lblRaton.TabIndex = 10;
            lblRaton.Text = "lblRaton";
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // Form15Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 454);
            Controls.Add(lblRaton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDoble);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(lbl1);
            Name = "Form15Metodos";
            Text = "Form15Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDoble;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblRaton;
    }
}