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
    public partial class Catalogo : Form
    {
        ClassEntidad_Producto objent = new ClassEntidad_Producto();
        ClassNegocio_Producto objneg = new ClassNegocio_Producto();
        public Catalogo()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {

        }

        public void Validar_Cantidad_Producto(String producto, int cantidadProducto)
        {
            objent.Nombre_Producto = producto;
            DataTable dt = new DataTable();
            dt = objneg.N_Buscar_Producto(objent);
            DataGridView lista = new DataGridView();
            lista.DataSource = dt;
            int fila = lista.CurrentCell.RowIndex;
            String valor = lista[3, fila].Value.ToString();
            int cantidad = Convert.ToInt32(valor);
            if (cantidad > 0)
            {
                objent.Cantidad = cantidadProducto;
                string men = objneg.N_Mantenimiento_Producto(objent);
                MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("El producto no tiene existencias", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
