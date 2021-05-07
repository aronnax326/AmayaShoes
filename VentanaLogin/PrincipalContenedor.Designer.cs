
using System;

namespace VentanaLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Imagen_Cerrar = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.panelTema = new System.Windows.Forms.Panel();
            this.lblReproductor = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnSalirPanel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Imagen_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 616);
            this.panel2.TabIndex = 1;
            // 
            // Imagen_Cerrar
            // 
            this.Imagen_Cerrar.Image = global::VentanaLogin.Properties.Resources.cerrar;
            this.Imagen_Cerrar.Location = new System.Drawing.Point(890, 5);
            this.Imagen_Cerrar.Name = "Imagen_Cerrar";
            this.Imagen_Cerrar.Size = new System.Drawing.Size(16, 16);
            this.Imagen_Cerrar.TabIndex = 0;
            this.Imagen_Cerrar.TabStop = false;
            this.Imagen_Cerrar.Click += new System.EventHandler(this.Imagen_Cerrar_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::VentanaLogin.Properties.Resources.play_button;
            this.btnPlay.Location = new System.Drawing.Point(22, 644);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPlay.TabIndex = 1;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::VentanaLogin.Properties.Resources.stop_button;
            this.btnStop.Location = new System.Drawing.Point(64, 644);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 32);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnStop.TabIndex = 2;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panelTema
            // 
            this.panelTema.BackColor = System.Drawing.Color.White;
            this.panelTema.Location = new System.Drawing.Point(243, 26);
            this.panelTema.Name = "panelTema";
            this.panelTema.Size = new System.Drawing.Size(675, 688);
            this.panelTema.TabIndex = 3;
            // 
            // lblReproductor
            // 
            this.lblReproductor.AutoSize = true;
            this.lblReproductor.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReproductor.ForeColor = System.Drawing.Color.White;
            this.lblReproductor.Location = new System.Drawing.Point(12, 605);
            this.lblReproductor.Name = "lblReproductor";
            this.lblReproductor.Size = new System.Drawing.Size(171, 21);
            this.lblReproductor.TabIndex = 9;
            this.lblReproductor.Text = "Reproductor de música";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::VentanaLogin.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 82);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(242, 42);
            this.btnHome.TabIndex = 18;
            this.btnHome.Text = "Principal";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalogo.FlatAppearance.BorderSize = 0;
            this.btnCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnCatalogo.Image = global::VentanaLogin.Properties.Resources.catalogo;
            this.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.Location = new System.Drawing.Point(0, 130);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(242, 42);
            this.btnCatalogo.TabIndex = 19;
            this.btnCatalogo.Text = "Catalogo";
            this.btnCatalogo.UseVisualStyleBackColor = false;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarrito.FlatAppearance.BorderSize = 0;
            this.btnCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrito.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarrito.ForeColor = System.Drawing.Color.White;
            this.btnCarrito.Image = global::VentanaLogin.Properties.Resources.shopping_cart;
            this.btnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrito.Location = new System.Drawing.Point(0, 178);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(242, 42);
            this.btnCarrito.TabIndex = 20;
            this.btnCarrito.Text = "Carrito de compras";
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEventos.ForeColor = System.Drawing.Color.White;
            this.btnEventos.Image = global::VentanaLogin.Properties.Resources.calendario;
            this.btnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventos.Location = new System.Drawing.Point(0, 226);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(242, 42);
            this.btnEventos.TabIndex = 21;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnSalirPanel
            // 
            this.btnSalirPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalirPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirPanel.FlatAppearance.BorderSize = 0;
            this.btnSalirPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSalirPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirPanel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalirPanel.ForeColor = System.Drawing.Color.White;
            this.btnSalirPanel.Image = global::VentanaLogin.Properties.Resources.log_out1;
            this.btnSalirPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirPanel.Location = new System.Drawing.Point(0, 274);
            this.btnSalirPanel.Name = "btnSalirPanel";
            this.btnSalirPanel.Size = new System.Drawing.Size(242, 42);
            this.btnSalirPanel.TabIndex = 22;
            this.btnSalirPanel.Text = "Salir";
            this.btnSalirPanel.UseVisualStyleBackColor = false;
            this.btnSalirPanel.Click += new System.EventHandler(this.btnSalirPanel_Click);
            // 
            // PrincipalContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(919, 712);
            this.Controls.Add(this.btnSalirPanel);
            this.Controls.Add(this.btnEventos);
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
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
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
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnSalirPanel;
    }
}