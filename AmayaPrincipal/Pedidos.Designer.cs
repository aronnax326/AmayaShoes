
namespace AmayaPrincipal
{
    partial class Pedidos
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
            this.components = new System.ComponentModel.Container();
            this.lblCarrito1 = new System.Windows.Forms.Label();
            this.lblCarrito2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewProd = new System.Windows.Forms.DataGridView();
            this.dataGridViewListar = new System.Windows.Forms.DataGridView();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumPedido = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.labIdentificacion = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labDireccion = new System.Windows.Forms.Label();
            this.labTelefono = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.labCodigo = new System.Windows.Forms.Label();
            this.labCantidad = new System.Windows.Forms.Label();
            this.btnPedir = new System.Windows.Forms.Button();
            this.labFecha = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.textNomProducto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrito1
            // 
            this.lblCarrito1.AutoSize = true;
            this.lblCarrito1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCarrito1.Location = new System.Drawing.Point(245, 22);
            this.lblCarrito1.Name = "lblCarrito1";
            this.lblCarrito1.Size = new System.Drawing.Size(91, 30);
            this.lblCarrito1.TabIndex = 0;
            this.lblCarrito1.Text = "Pedidos";
            // 
            // lblCarrito2
            // 
            this.lblCarrito2.AutoSize = true;
            this.lblCarrito2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito2.Location = new System.Drawing.Point(246, 107);
            this.lblCarrito2.Name = "lblCarrito2";
            this.lblCarrito2.Size = new System.Drawing.Size(167, 21);
            this.lblCarrito2.TabIndex = 1;
            this.lblCarrito2.Text = " Pedido un Numero :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewProd);
            this.groupBox1.Controls.Add(this.dataGridViewListar);
            this.groupBox1.Controls.Add(this.dataGridViewPedido);
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // dataGridViewProd
            // 
            this.dataGridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProd.Location = new System.Drawing.Point(23, 30);
            this.dataGridViewProd.Name = "dataGridViewProd";
            this.dataGridViewProd.Size = new System.Drawing.Size(465, 98);
            this.dataGridViewProd.TabIndex = 2;
            this.dataGridViewProd.Visible = false;
            // 
            // dataGridViewListar
            // 
            this.dataGridViewListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListar.Location = new System.Drawing.Point(15, 22);
            this.dataGridViewListar.Name = "dataGridViewListar";
            this.dataGridViewListar.Size = new System.Drawing.Size(465, 98);
            this.dataGridViewListar.TabIndex = 1;
            this.dataGridViewListar.Visible = false;
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Location = new System.Drawing.Point(15, 38);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.Size = new System.Drawing.Size(465, 98);
            this.dataGridViewPedido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // textNumPedido
            // 
            this.textNumPedido.Enabled = false;
            this.textNumPedido.Location = new System.Drawing.Point(433, 107);
            this.textNumPedido.Name = "textNumPedido";
            this.textNumPedido.ReadOnly = true;
            this.textNumPedido.Size = new System.Drawing.Size(46, 20);
            this.textNumPedido.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(228, 544);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(122, 40);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar ";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(166, 161);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textIdentificacion.TabIndex = 6;
            // 
            // textApellido
            // 
            this.textApellido.Enabled = false;
            this.textApellido.Location = new System.Drawing.Point(405, 195);
            this.textApellido.Name = "textApellido";
            this.textApellido.ReadOnly = true;
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 7;
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(166, 201);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 8;
            // 
            // textTelefono
            // 
            this.textTelefono.Enabled = false;
            this.textTelefono.Location = new System.Drawing.Point(405, 238);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.ReadOnly = true;
            this.textTelefono.Size = new System.Drawing.Size(100, 20);
            this.textTelefono.TabIndex = 9;
            // 
            // labIdentificacion
            // 
            this.labIdentificacion.AutoSize = true;
            this.labIdentificacion.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdentificacion.Location = new System.Drawing.Point(47, 161);
            this.labIdentificacion.Name = "labIdentificacion";
            this.labIdentificacion.Size = new System.Drawing.Size(96, 17);
            this.labIdentificacion.TabIndex = 10;
            this.labIdentificacion.Text = "Identificación:";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(47, 201);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(62, 17);
            this.labNombre.TabIndex = 11;
            this.labNombre.Text = "Nombre:";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(296, 201);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(64, 17);
            this.labApellido.TabIndex = 12;
            this.labApellido.Text = "Apellido:";
            // 
            // labDireccion
            // 
            this.labDireccion.AutoSize = true;
            this.labDireccion.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDireccion.Location = new System.Drawing.Point(47, 241);
            this.labDireccion.Name = "labDireccion";
            this.labDireccion.Size = new System.Drawing.Size(70, 17);
            this.labDireccion.TabIndex = 13;
            this.labDireccion.Text = "Dirección:";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefono.Location = new System.Drawing.Point(296, 241);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(67, 17);
            this.labTelefono.TabIndex = 14;
            this.labTelefono.Text = "Teléfono:";
            // 
            // textDireccion
            // 
            this.textDireccion.Enabled = false;
            this.textDireccion.Location = new System.Drawing.Point(166, 241);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.ReadOnly = true;
            this.textDireccion.Size = new System.Drawing.Size(100, 20);
            this.textDireccion.TabIndex = 15;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(138, 321);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(48, 20);
            this.textCodigo.TabIndex = 16;
            this.textCodigo.TextChanged += new System.EventHandler(this.textCodigo_TextChanged);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(138, 353);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(48, 20);
            this.textCantidad.TabIndex = 17;
          
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCodigo.Location = new System.Drawing.Point(42, 321);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(56, 17);
            this.labCodigo.TabIndex = 19;
            this.labCodigo.Text = "Código:";
            // 
            // labCantidad
            // 
            this.labCantidad.AutoSize = true;
            this.labCantidad.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantidad.Location = new System.Drawing.Point(42, 353);
            this.labCantidad.Name = "labCantidad";
            this.labCantidad.Size = new System.Drawing.Size(67, 17);
            this.labCantidad.TabIndex = 20;
            this.labCantidad.Text = "Cantidad:";
            // 
            // btnPedir
            // 
            this.btnPedir.Image = global::AmayaPrincipal.Properties.Resources.shopping_cart;
            this.btnPedir.Location = new System.Drawing.Point(416, 328);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(75, 53);
            this.btnPedir.TabIndex = 21;
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha.Location = new System.Drawing.Point(51, 113);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(47, 17);
            this.labFecha.TabIndex = 22;
            this.labFecha.Text = "Fecha:";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(204, 356);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(62, 17);
            this.C.TabIndex = 23;
            this.C.Text = "Nombre:";
            // 
            // textNomProducto
            // 
            this.textNomProducto.Enabled = false;
            this.textNomProducto.Location = new System.Drawing.Point(282, 352);
            this.textNomProducto.Name = "textNomProducto";
            this.textNomProducto.ReadOnly = true;
            this.textNomProducto.Size = new System.Drawing.Size(100, 20);
            this.textNomProducto.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(307, 161);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Fecha
            // 
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "label2";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 596);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textNomProducto);
            this.Controls.Add(this.C);
            this.Controls.Add(this.labFecha);
            this.Controls.Add(this.btnPedir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.labCantidad);
            this.Controls.Add(this.labCodigo);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.labTelefono);
            this.Controls.Add(this.labDireccion);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.labIdentificacion);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textIdentificacion);
            this.Controls.Add(this.textNumPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCarrito2);
            this.Controls.Add(this.lblCarrito1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 25);
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrito1;
        private System.Windows.Forms.Label lblCarrito2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumPedido;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label labIdentificacion;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labDireccion;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.Label labCantidad;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.TextBox textNomProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewListar;
        private System.Windows.Forms.DataGridView dataGridViewProd;
        private System.Windows.Forms.Timer Fecha;
        private System.Windows.Forms.Label label2;
    }
}