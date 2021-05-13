
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grupProducDisponible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lablProductos
            // 
            this.lablProductos.AutoSize = true;
            this.lablProductos.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablProductos.Location = new System.Drawing.Point(223, 25);
            this.lablProductos.Name = "lablProductos";
            this.lablProductos.Size = new System.Drawing.Size(113, 30);
            this.lablProductos.TabIndex = 0;
            this.lablProductos.Text = "Productos";
            // 
            // grupProducDisponible
            // 
            this.grupProducDisponible.Controls.Add(this.dataGridView1);
            this.grupProducDisponible.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupProducDisponible.Location = new System.Drawing.Point(12, 141);
            this.grupProducDisponible.Name = "grupProducDisponible";
            this.grupProducDisponible.Size = new System.Drawing.Size(523, 345);
            this.grupProducDisponible.TabIndex = 1;
            this.grupProducDisponible.TabStop = false;
            this.grupProducDisponible.Text = "Productos Disponibles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 17);
            this.panel1.TabIndex = 2;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grupProducDisponible);
            this.Controls.Add(this.lablProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.grupProducDisponible.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablProductos;
        private System.Windows.Forms.GroupBox grupProducDisponible;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}