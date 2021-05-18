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
            try
            {
                objent.Codigo = textCodigo.Text;
                objent.Nombre_Producto = textNombre.Text;
                objent.Descripcion = textDescripcion.Text;
                objent.Precio = Convert.ToInt32(textPrecio.Text);
                objent.Cantidad = Convert.ToInt32(textCantidad.Text);
                objent.Accion = accion;
                string men = objneg.N_Mantenimiento_Producto(objent);

                MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique los datos y trate de nuevo.");
            }

        }
        void limpiar()
        {
           textCodigo.Text = "";
           textNombre.Text = "";
           textCantidad.Text = "";
           textDescripcion.Text = "";
           textPrecio.Text = "";
           dataGridLista.DataSource = objneg.N_listar_Productos();
        }
        //eventos

       

       

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (textCodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + textNombre.Text + "?", "Mensaje",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento_Productos("3");
                    limpiar();
                }

            }
        }

        private void Productos_Load_1(object sender, EventArgs e)
        {
            dataGridLista.DataSource = objneg.N_listar_Productos();
        }

        private void dataGridLista_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridLista.CurrentCell.RowIndex;

            textCodigo.Text = dataGridLista[0, fila].Value.ToString();
            textPrecio.Text = dataGridLista[4, fila].Value.ToString();
            textNombre.Text = dataGridLista[1, fila].Value.ToString();
            textDescripcion.Text = dataGridLista[2, fila].Value.ToString();
            textCantidad.Text = dataGridLista[3, fila].Value.ToString();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

       

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + textNombre.Text + "?", "Mensaje",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento_Productos("2");
                    limpiar();

                }

            }
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textCodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas Registrar Nuevo Producto" + textNombre.Text + "?", "Mensaje",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento_Productos("1");
                    limpiar();
                }
            }
        }
    }
}



