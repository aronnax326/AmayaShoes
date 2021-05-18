
namespace AmayaPrincipal
{
    partial class Productos
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
            this.lablProductos = new System.Windows.Forms.Label();
            this.grupProducDisponible = new System.Windows.Forms.GroupBox();
            this.dataGridLista = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DetallesProductos = new System.Windows.Forms.GroupBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grupProducDisponible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.DetallesProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lablProductos
            // 
            this.lablProductos.AutoSize = true;
            this.lablProductos.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablProductos.Location = new System.Drawing.Point(375, 70);
            this.lablProductos.Name = "lablProductos";
            this.lablProductos.Size = new System.Drawing.Size(113, 30);
            this.lablProductos.TabIndex = 0;
            this.lablProductos.Text = "Productos";
            // 
            // grupProducDisponible
            // 
            this.grupProducDisponible.Controls.Add(this.dataGridLista);
            this.grupProducDisponible.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupProducDisponible.Location = new System.Drawing.Point(12, 618);
            this.grupProducDisponible.Name = "grupProducDisponible";
            this.grupProducDisponible.Size = new System.Drawing.Size(798, 252);
            this.grupProducDisponible.TabIndex = 1;
            this.grupProducDisponible.TabStop = false;
            this.grupProducDisponible.Text = "Productos Disponibles";
            // 
            // dataGridLista
            // 
            this.dataGridLista.AllowUserToAddRows = false;
            this.dataGridLista.AllowUserToDeleteRows = false;
            this.dataGridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLista.Location = new System.Drawing.Point(21, 54);
            this.dataGridLista.Name = "dataGridLista";
            this.dataGridLista.ReadOnly = true;
            this.dataGridLista.Size = new System.Drawing.Size(752, 185);
            this.dataGridLista.TabIndex = 0;
            this.dataGridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLista_CellContentClick_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.registrarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 20);
            this.panel1.TabIndex = 4;
            // 
            // DetallesProductos
            // 
            this.DetallesProductos.Controls.Add(this.textDescripcion);
            this.DetallesProductos.Controls.Add(this.textCantidad);
            this.DetallesProductos.Controls.Add(this.textNombre);
            this.DetallesProductos.Controls.Add(this.textPrecio);
            this.DetallesProductos.Controls.Add(this.textCodigo);
            this.DetallesProductos.Controls.Add(this.label5);
            this.DetallesProductos.Controls.Add(this.label4);
            this.DetallesProductos.Controls.Add(this.label3);
            this.DetallesProductos.Controls.Add(this.label2);
            this.DetallesProductos.Controls.Add(this.label1);
            this.DetallesProductos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetallesProductos.Location = new System.Drawing.Point(12, 272);
            this.DetallesProductos.Name = "DetallesProductos";
            this.DetallesProductos.Size = new System.Drawing.Size(798, 340);
            this.DetallesProductos.TabIndex = 5;
            this.DetallesProductos.TabStop = false;
            this.DetallesProductos.Text = "Datos de Producto";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(132, 212);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(581, 104);
            this.textDescripcion.TabIndex = 9;
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(132, 157);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(85, 29);
            this.textCantidad.TabIndex = 8;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(132, 106);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(159, 29);
            this.textNombre.TabIndex = 7;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(566, 53);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(85, 29);
            this.textPrecio.TabIndex = 6;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(132, 53);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(85, 29);
            this.textCodigo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referencia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AmayaPrincipal.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(366, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 633);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DetallesProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grupProducDisponible);
            this.Controls.Add(this.lablProductos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load_1);
            this.grupProducDisponible.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DetallesProductos.ResumeLayout(false);
            this.DetallesProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablProductos;
        private System.Windows.Forms.GroupBox grupProducDisponible;
        private System.Windows.Forms.DataGridView dataGridLista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox DetallesProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}