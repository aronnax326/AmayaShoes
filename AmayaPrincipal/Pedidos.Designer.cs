
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
            this.lblCarrito1 = new System.Windows.Forms.Label();
            this.lblCarrito2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCarrito1
            // 
            this.lblCarrito1.AutoSize = true;
            this.lblCarrito1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCarrito1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCarrito1.Location = new System.Drawing.Point(252, 26);
            this.lblCarrito1.Name = "lblCarrito1";
            this.lblCarrito1.Size = new System.Drawing.Size(90, 30);
            this.lblCarrito1.TabIndex = 0;
            this.lblCarrito1.Text = "Pedidos";
            // 
            // lblCarrito2
            // 
            this.lblCarrito2.AutoSize = true;
            this.lblCarrito2.Font = new System.Drawing.Font("Ebrima", 12F);
            this.lblCarrito2.Location = new System.Drawing.Point(182, 148);
            this.lblCarrito2.Name = "lblCarrito2";
            this.lblCarrito2.Size = new System.Drawing.Size(226, 21);
            this.lblCarrito2.TabIndex = 1;
            this.lblCarrito2.Text = "No hay productos en el pedido.";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 596);
            this.Controls.Add(this.lblCarrito2);
            this.Controls.Add(this.lblCarrito1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 25);
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrito1;
        private System.Windows.Forms.Label lblCarrito2;
    }
}