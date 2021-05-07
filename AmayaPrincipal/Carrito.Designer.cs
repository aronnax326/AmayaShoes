
namespace AmayaPrincipal
{
    partial class Carrito
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
            this.lblCarrito1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarrito1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCarrito1.Location = new System.Drawing.Point(229, 25);
            this.lblCarrito1.Name = "lblCarrito1";
            this.lblCarrito1.Size = new System.Drawing.Size(199, 30);
            this.lblCarrito1.TabIndex = 0;
            this.lblCarrito1.Text = "Carrito de compras";
            // 
            // lblCarrito2
            // 
            this.lblCarrito2.AutoSize = true;
            this.lblCarrito2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrito2.Location = new System.Drawing.Point(172, 173);
            this.lblCarrito2.Name = "lblCarrito2";
            this.lblCarrito2.Size = new System.Drawing.Size(308, 21);
            this.lblCarrito2.TabIndex = 1;
            this.lblCarrito2.Text = "No hay productos en el carrito de compras.";
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 688);
            this.Controls.Add(this.lblCarrito2);
            this.Controls.Add(this.lblCarrito1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 25);
            this.Name = "Carrito";
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