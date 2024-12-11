namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            chkFormato = new CheckBox();
            label1 = new Label();
            txtFechaActual = new TextBox();
            groupBox1 = new GroupBox();
            txtIncremento = new TextBox();
            btnIncremento = new Button();
            label2 = new Label();
            rdbAnios = new RadioButton();
            rdbMeses = new RadioButton();
            rdbDias = new RadioButton();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(66, 106);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(151, 19);
            chkFormato.TabIndex = 0;
            chkFormato.Text = "Cambiar formato Fecha";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(66, 33);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(66, 64);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(283, 23);
            txtFechaActual.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(btnIncremento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbAnios);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Location = new Point(66, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 118);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(183, 52);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 5;
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(183, 78);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(100, 23);
            btnIncremento.TabIndex = 4;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 29);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // rdbAnios
            // 
            rdbAnios.AutoSize = true;
            rdbAnios.Location = new Point(6, 93);
            rdbAnios.Name = "rdbAnios";
            rdbAnios.Size = new Size(52, 19);
            rdbAnios.TabIndex = 2;
            rdbAnios.TabStop = true;
            rdbAnios.Text = "Años";
            rdbAnios.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(6, 56);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 1;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(6, 22);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 0;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 312);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "NuevaFecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(72, 350);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(277, 23);
            txtNuevaFecha.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 416);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Controls.Add(chkFormato);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkFormato;
        private Label label1;
        private TextBox txtFechaActual;
        private GroupBox groupBox1;
        private RadioButton rdbAnios;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnIncremento;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}