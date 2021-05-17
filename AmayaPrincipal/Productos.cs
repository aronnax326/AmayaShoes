using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;


namespace AmayaPrincipal
{
     public partial class Productos : Form
    {
        ClassEntidad_Producto objent = new ClassEntidad_Producto();
        ClassNegocio_Producto objneg = new ClassNegocio_Producto();

        public Productos()
        {
            InitializeComponent();

        }
        //Metodo  
        void Mantenimiento_Productos(string accion)
        {

            objent.Codigo = textCodigo.Text;
            objent.Nombre_Producto = textNombreProducto.Text;
            objent.Accion = accion;
            string men = objneg.N_Mantenimiento_Producto(objent);

            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        void limpiar()
        {
           textCodigo.Text = "";
           textNombreProducto.Text = "";
           textCantidad.Text = "";
           dataGridView1.DataSource = objneg.N_listar_Productos();
        }
        //eventos

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas Registrar Nuevo Producto" + textNombreProducto.Text + "?", "Mensaje",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                   Mantenimiento_Productos("1");
                    limpiar();
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text != "")
            {
              if (MessageBox.Show("¿Deseas modificar a " + textNombreProducto.Text + "?", "Mensaje",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
              {
                Mantenimiento_Productos("2");
                limpiar();

              }

            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + textNombreProducto.Text + "?", "Mensaje",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                  Mantenimiento_Productos("3");
                  limpiar();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            textCodigo.Text = dataGridView1[0, fila].Value.ToString();

            textNombreProducto.Text = dataGridView1[1, fila].Value.ToString();

            textCantidad.Text = dataGridView1[2, fila].Value.ToString();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}



