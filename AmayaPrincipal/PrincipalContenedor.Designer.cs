
namespace AmayaPrincipal
{
    partial class PrincipalContenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalContenedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Imagen_Cerrar = new System.Windows.Forms.PictureBox();
            this.panelTema = new System.Windows.Forms.Panel();
            this.lblReproductor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnSalirPanel = new System.Windows.Forms.Button();
            this.btnRegistroPersonal = new System.Windows.Forms.Button();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Imagen_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 22);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Amaya Shoes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 534);
            this.panel2.TabIndex = 1;
            // 
            // Imagen_Cerrar
            // 
            this.Imagen_Cerrar.Image = global::AmayaPrincipal.Properties.Resources.cerrar;
            this.Imagen_Cerrar.Location = new System.Drawing.Point(763, 4);
            this.Imagen_Cerrar.Name = "Imagen_Cerrar";
            this.Imagen_Cerrar.Size = new System.Drawing.Size(14, 14);
            this.Imagen_Cerrar.TabIndex = 0;
            this.Imagen_Cerrar.TabStop = false;
            this.Imagen_Cerrar.Click += new System.EventHandler(this.Imagen_Cerrar_Click);
            // 
            // panelTema
            // 
            this.panelTema.BackColor = System.Drawing.Color.White;
            this.panelTema.Location = new System.Drawing.Point(208, 23);
            this.panelTema.Name = "panelTema";
            this.panelTema.Size = new System.Drawing.Size(579, 596);
            this.panelTema.TabIndex = 3;
            // 
            // lblReproductor
            // 
            this.lblReproductor.AutoSize = true;
            this.lblReproductor.Font = new System.Drawing.Font("Ebrima", 12F);
            this.lblReproductor.ForeColor = System.Drawing.Color.White;
            this.lblReproductor.Location = new System.Drawing.Point(10, 524);
            this.lblReproductor.Name = "lblReproductor";
            this.lblReproductor.Size = new System.Drawing.Size(171, 21);
            this.lblReproductor.TabIndex = 9;
            this.lblReproductor.Text = "Reproductor de música";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Bienvenido ";
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Ebrima", 12F);
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = global::AmayaPrincipal.Properties.Resources.box;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 242);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(207, 36);
            this.btnInventario.TabIndex = 24;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnSalirPanel
            // 
            this.btnSalirPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalirPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirPanel.FlatAppearance.BorderSize = 0;
            this.btnSalirPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSalirPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirPanel.Font = new System.Drawing.Font("Ebrima", 12F);
            this.btnSalirPanel.ForeColor = System.Drawing.Color.White;
            this.btnSalirPanel.Image = global::AmayaPrincipal.Properties.Resources.log_out;
            this.btnSalirPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirPanel.Location = new System.Drawing.Point(0, 284);
            this.btnSalirPanel.Name = "btnSalirPanel";
            this.btnSalirPanel.Size = new System.Drawing.Size(207, 36);
            this.btnSalirPanel.TabIndex = 22;
            this.btnSalirPanel.Text = "Salir";
            this.btnSalirPanel.UseVisualStyleBackColor = false;
            this.btnSalirPanel.Click += new System.EventHandler(this.btnSalirPanel_Click);
            // 
            // btnRegistroPersonal
            // 
            this.btnRegistroPersonal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistroPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroPersonal.FlatAppearance.BorderSize = 0;
            this.btnRegistroPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnRegistroPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroPersonal.Font = new System.Drawing.Font("Ebrima", 12F);
            this.btnRegistroPersonal.ForeColor = System.Drawing.Color.White;
            this.btnRegistroPersonal.Image = global::AmayaPrincipal.Properties.Resources.user;
            this.btnRegistroPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroPersonal.Location = new System.Drawing.Point(0, 196);
            this.btnRegistroPersonal.Name = "btnRegistroPersonal";
            this.btnRegistroPersonal.Size = new System.Drawing.Size(207, 36);
            this.btnRegistroPersonal.TabIndex = 21;
            this.btnRegistroPersonal.Text = "Empleados";
            this.btnRegistroPersonal.UseVisualStyleBackColor = false;
            this.btnRegistroPersonal.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarrito.FlatAppearance.BorderSize = 0;
            this.btnCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrito.Font = new System.Drawing.Font("Ebrima", 12F);
            this.btnCarrito.ForeColor = System.Drawing.Color.White;
            this.btnCarrito.Image = global::AmayaPrincipal.Properties.Resources.shopping_cart;
            this.btnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrito.Location = new System.Drawing.Point(0, 154);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(207, 36);
            this.btnCarrito.TabIndex = 20;
            this.btnCarrito.Text = "Pedidos";
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalogo.FlatAppearance.BorderSize = 0;
            this.btnCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.Font = new System.Drawing.Font("Ebrima", 12F);
            this.btnCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnCatalogo.Image = global::AmayaPrincipal.Properties.Resources.catalogo;
            this.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.Location = new System.Drawing.Point(0, 113);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(207, 36);
            this.btnCatalogo.TabIndex = 19;
            this.btnCatalogo.Text = "Catalogo";
            this.btnCatalogo.UseVisualStyleBackColor = false;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Ebrima", 12F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::AmayaPrincipal.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 71);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(207, 36);
            this.btnHome.TabIndex = 18;
            this.btnHome.Text = "Principal";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::AmayaPrincipal.Properties.Resources.detener;
            this.btnStop.Location = new System.Drawing.Point(55, 558);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(24, 24);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnStop.TabIndex = 2;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::AmayaPrincipal.Properties.Resources.jugar;
            this.btnPlay.Location = new System.Drawing.Point(19, 558);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(24, 24);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPlay.TabIndex = 1;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // PrincipalContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(788, 617);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalirPanel);
            this.Controls.Add(this.btnRegistroPersonal);
            this.Controls.Add(this.btnCarrito);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblReproductor);
            this.Controls.Add(this.panelTema);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Imagen_Cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.Panel panelTema;
        private System.Windows.Forms.Label lblReproductor;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Button btnRegistroPersonal;
        private System.Windows.Forms.Button btnSalirPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInventario;
    }
}