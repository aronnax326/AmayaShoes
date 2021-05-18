using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;

namespace AmayaPrincipal
{
    public partial class PedidosRealizados : Form
    {
        ClassEntidad_Pedido objent = new ClassEntidad_Pedido();
        ClassNegocio_Pedido objneg = new ClassNegocio_Pedido();
        public PedidosRealizados()
        {
            InitializeComponent();
        }

        private void dataGridPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridPedidos.CurrentCell.RowIndex;
            txtCantidad.Text = dataGridPedidos[4, fila].Value.ToString();
            txtNomProducto.Text = dataGridPedidos[3, fila].Value.ToString();
            txtPedido.Text = dataGridPedidos[0, fila].Value.ToString();
            txtIdentificacion.Text = dataGridPedidos[1, fila].Value.ToString();
            txtReferencia.Text = dataGridPedidos[5, fila].Value.ToString();
        }

        private void PedidosRealizados_Load(object sender, EventArgs e)
        {
            dataGridPedidos.DataSource = objneg.N_Listar_Pedidos();
        }

        void mantenimiento(string accion)
        {
            try
            {
                objent.Numero_Pedido = Convert.ToInt32(txtPedido.Text);
                objent.Cantidad = Convert.ToInt32(txtCantidad.Text);
                objent.Nombre_Producto = txtNomProducto.Text;
                objent.Codigo = txtReferencia.Text;
                objent.Identificacion = Convert.ToInt32(txtIdentificacion.Text);
                objent.Fecha = DateTime.Now.Date;
                objent.Accion = accion;
                string men = objneg.N_Mantenimiento_Pedido(objent);
                MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Valide los datos y luego vuelva a intentar.");
            }
        }

        void limpiar()
        {
            txtCantidad.Text = "";
            txtNomProducto.Text = "";
            txtIdentificacion.Text = "";
            txtPedido.Text = "";
            txtReferencia.Text = "";
            dataGridPedidos.DataSource = objneg.N_Listar_Pedidos();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento("2");
            limpiar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento("3");
            limpiar();
        }
    }
}
