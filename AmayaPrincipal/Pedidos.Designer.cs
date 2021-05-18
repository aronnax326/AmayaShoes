
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
            this.labNomProducto = new System.Windows.Forms.Label();
            this.textNomProducto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textFecha = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrito1
            // 
            this.lblCarrito1.AutoSize = true;
            this.lblCarrito1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCarrito1.Location = new System.Drawing.Point(243, 63);
            this.lblCarrito1.Name = "lblCarrito1";
            this.lblCarrito1.Size = new System.Drawing.Size(91, 30);
            this.lblCarrito1.TabIndex = 0;
            this.lblCarrito1.Text = "Pedidos";
            // 
            // lblCarrito2
            // 
            this.lblCarrito2.AutoSize = true;
            this.lblCarrito2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito2.Location = new System.Drawing.Point(256, 251);
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
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 538);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // dataGridViewProd
            // 
            this.dataGridViewProd.AllowUserToAddRows = false;
            this.dataGridViewProd.AllowUserToDeleteRows = false;
            this.dataGridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProd.Location = new System.Drawing.Point(23, 30);
            this.dataGridViewProd.Name = "dataGridViewProd";
            this.dataGridViewProd.ReadOnly = true;
            this.dataGridViewProd.Size = new System.Drawing.Size(484, 98);
            this.dataGridViewProd.TabIndex = 2;
            this.dataGridViewProd.Visible = false;
            // 
            // dataGridViewListar
            // 
            this.dataGridViewListar.AllowUserToAddRows = false;
            this.dataGridViewListar.AllowUserToDeleteRows = false;
            this.dataGridViewListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListar.Location = new System.Drawing.Point(15, 22);
            this.dataGridViewListar.Name = "dataGridViewListar";
            this.dataGridViewListar.ReadOnly = true;
            this.dataGridViewListar.Size = new System.Drawing.Size(492, 98);
            this.dataGridViewListar.TabIndex = 1;
            this.dataGridViewListar.Visible = false;
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.AllowUserToAddRows = false;
            this.dataGridViewPedido.AllowUserToDeleteRows = false;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Location = new System.Drawing.Point(15, 38);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.ReadOnly = true;
            this.dataGridViewPedido.Size = new System.Drawing.Size(465, 98);
            this.dataGridViewPedido.TabIndex = 0;
            // 
            // textNumPedido
            // 
            this.textNumPedido.Enabled = false;
            this.textNumPedido.Location = new System.Drawing.Point(443, 251);
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
            this.btnConfirmar.Location = new System.Drawing.Point(222, 696);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(122, 40);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar ";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(176, 305);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.textIdentificacion.TabIndex = 6;
            // 
            // textApellido
            // 
            this.textApellido.Enabled = false;
            this.textApellido.Location = new System.Drawing.Point(415, 339);
            this.textApellido.Name = "textApellido";
            this.textApellido.ReadOnly = true;
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 7;
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(176, 345);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 8;
            // 
            // textTelefono
            // 
            this.textTelefono.Enabled = false;
            this.textTelefono.Location = new System.Drawing.Point(415, 382);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.ReadOnly = true;
            this.textTelefono.Size = new System.Drawing.Size(100, 20);
            this.textTelefono.TabIndex = 9;
            // 
            // labIdentificacion
            // 
            this.labIdentificacion.AutoSize = true;
            this.labIdentificacion.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdentificacion.Location = new System.Drawing.Point(57, 305);
            this.labIdentificacion.Name = "labIdentificacion";
            this.labIdentificacion.Size = new System.Drawing.Size(96, 17);
            this.labIdentificacion.TabIndex = 10;
            this.labIdentificacion.Text = "Identificación:";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(57, 345);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(62, 17);
            this.labNombre.TabIndex = 11;
            this.labNombre.Text = "Nombre:";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(306, 345);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(64, 17);
            this.labApellido.TabIndex = 12;
            this.labApellido.Text = "Apellido:";
            // 
            // labDireccion
            // 
            this.labDireccion.AutoSize = true;
            this.labDireccion.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDireccion.Location = new System.Drawing.Point(57, 385);
            this.labDireccion.Name = "labDireccion";
            this.labDireccion.Size = new System.Drawing.Size(70, 17);
            this.labDireccion.TabIndex = 13;
            this.labDireccion.Text = "Dirección:";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefono.Location = new System.Drawing.Point(306, 385);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(67, 17);
            this.labTelefono.TabIndex = 14;
            this.labTelefono.Text = "Teléfono:";
            // 
            // textDireccion
            // 
            this.textDireccion.Enabled = false;
            this.textDireccion.Location = new System.Drawing.Point(176, 385);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.ReadOnly = true;
            this.textDireccion.Size = new System.Drawing.Size(100, 20);
            this.textDireccion.TabIndex = 15;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(153, 443);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(48, 20);
            this.textCodigo.TabIndex = 16;
            this.textCodigo.TextChanged += new System.EventHandler(this.textCodigo_TextChanged);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(153, 475);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(48, 20);
            this.textCantidad.TabIndex = 17;
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCodigo.Location = new System.Drawing.Point(57, 443);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(56, 17);
            this.labCodigo.TabIndex = 19;
            this.labCodigo.Text = "Código:";
            // 
            // labCantidad
            // 
            this.labCantidad.AutoSize = true;
            this.labCantidad.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantidad.Location = new System.Drawing.Point(57, 475);
            this.labCantidad.Name = "labCantidad";
            this.labCantidad.Size = new System.Drawing.Size(67, 17);
            this.labCantidad.TabIndex = 20;
            this.labCantidad.Text = "Cantidad:";
            // 
            // btnPedir
            // 
            this.btnPedir.Image = global::AmayaPrincipal.Properties.Resources.shopping_cart;
            this.btnPedir.Location = new System.Drawing.Point(431, 450);
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
            this.labFecha.Location = new System.Drawing.Point(61, 257);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(47, 17);
            this.labFecha.TabIndex = 22;
            this.labFecha.Text = "Fecha:";
            // 
            // labNomProducto
            // 
            this.labNomProducto.AutoSize = true;
            this.labNomProducto.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNomProducto.Location = new System.Drawing.Point(219, 478);
            this.labNomProducto.Name = "labNomProducto";
            this.labNomProducto.Size = new System.Drawing.Size(62, 17);
            this.labNomProducto.TabIndex = 23;
            this.labNomProducto.Text = "Nombre:";
            // 
            // textNomProducto
            // 
            this.textNomProducto.Enabled = false;
            this.textNomProducto.Location = new System.Drawing.Point(297, 474);
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
            this.btnBuscar.Location = new System.Drawing.Point(317, 305);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textFecha
            // 
            this.textFecha.AutoSize = true;
            this.textFecha.Location = new System.Drawing.Point(125, 260);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(35, 13);
            this.textFecha.TabIndex = 27;
            this.textFecha.Text = "label2";
            // 
            // Fecha
            // 
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 29);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 12F);
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(1, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 20);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AmayaPrincipal.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(222, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textNomProducto);
            this.Controls.Add(this.labNomProducto);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCarrito2);
            this.Controls.Add(this.lblCarrito1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 25);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrito1;
        private System.Windows.Forms.Label lblCarrito2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
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
        private System.Windows.Forms.Label labNomProducto;
        private System.Windows.Forms.TextBox textNomProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewListar;
        private System.Windows.Forms.DataGridView dataGridViewProd;
        private System.Windows.Forms.Label textFecha;
        private System.Windows.Forms.Timer Fecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}