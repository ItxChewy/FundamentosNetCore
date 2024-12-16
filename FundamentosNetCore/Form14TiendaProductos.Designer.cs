namespace FundamentosNetCore
{
    partial class Form14TiendaProductos
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
            txtProducto = new TextBox();
            btnNuevoProducto = new Button();
            btnEliminarProductos = new Button();
            btnEliminarTodosProductos = new Button();
            label2 = new Label();
            lstTienda = new ListBox();
            btnSeleccion = new Button();
            btnTodos = new Button();
            Almacen = new Label();
            lstAlmacen = new ListBox();
            btnSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(45, 59);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 1;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(45, 109);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(75, 23);
            btnNuevoProducto.TabIndex = 2;
            btnNuevoProducto.Text = "Nuevo";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnEliminarProductos
            // 
            btnEliminarProductos.Location = new Point(45, 147);
            btnEliminarProductos.Name = "btnEliminarProductos";
            btnEliminarProductos.Size = new Size(75, 23);
            btnEliminarProductos.TabIndex = 3;
            btnEliminarProductos.Text = "Eliminar";
            btnEliminarProductos.UseVisualStyleBackColor = true;
            btnEliminarProductos.Click += btnEliminarProductos_Click;
            // 
            // btnEliminarTodosProductos
            // 
            btnEliminarTodosProductos.Location = new Point(45, 185);
            btnEliminarTodosProductos.Name = "btnEliminarTodosProductos";
            btnEliminarTodosProductos.Size = new Size(75, 23);
            btnEliminarTodosProductos.TabIndex = 4;
            btnEliminarTodosProductos.Text = "BorrarTodo";
            btnEliminarTodosProductos.UseVisualStyleBackColor = true;
            btnEliminarTodosProductos.Click += btnEliminarTodosProductos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 33);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Tienda";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(229, 59);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(148, 199);
            lstTienda.TabIndex = 6;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(408, 101);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(75, 23);
            btnSeleccion.TabIndex = 7;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(408, 147);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 8;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // Almacen
            // 
            Almacen.AutoSize = true;
            Almacen.Location = new Point(492, 33);
            Almacen.Name = "Almacen";
            Almacen.Size = new Size(38, 15);
            Almacen.TabIndex = 9;
            Almacen.Text = "label3";
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(512, 59);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(146, 199);
            lstAlmacen.TabIndex = 10;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(691, 101);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(691, 147);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(75, 23);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // Form14TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 408);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(lstAlmacen);
            Controls.Add(Almacen);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(lstTienda);
            Controls.Add(label2);
            Controls.Add(btnEliminarTodosProductos);
            Controls.Add(btnEliminarProductos);
            Controls.Add(btnNuevoProducto);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "Form14TiendaProductos";
            Text = "Form14TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Button btnNuevoProducto;
        private Button btnEliminarProductos;
        private Button btnEliminarTodosProductos;
        private Label label2;
        private ListBox lstTienda;
        private Button btnSeleccion;
        private Button btnTodos;
        private Label Almacen;
        private ListBox lstAlmacen;
        private Button btnSubir;
        private Button btnBajar;
    }
}