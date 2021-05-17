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
    public partial class RegistroAdm : Form
    {
        ClassEntidad_Registro_Admin objent = new ClassEntidad_Registro_Admin();
        ClassNegocio_Registro_Admin objnegr = new ClassNegocio_Registro_Admin();
        ClassNegocio_Rol objr = new ClassNegocio_Rol();
        ClassNegocio_Clientes objneg = new ClassNegocio_Clientes ();
        public RegistroAdm()
        {
            InitializeComponent();
        }

        private void RegistroAdm_Load(object sender, EventArgs e)
        {
            DataTable dt = objr.N_Listar_Rol();
            this.comboBxRol.DataSource = dt;
            this.comboBxRol.DisplayMember = "nombre";
            this.comboBxRol.ValueMember = "idRol";

            dataGridListar.DataSource = objneg.N_Listar_Registados();
        }

        void mantenimiento(string accion)
        {
            objent.Usuario = textUsuario.Text;
            objent.Contrasena = textContrasena.Text;
            objent.Identificacion = Convert.ToInt32(txtIdentificacion.Text);
            objent.Nombre = txtNombre.Text;
            objent.Apellido = txtApellido.Text;
            objent.Direccion = textDireccion.Text;
            objent.Telefono = Convert.ToInt32(textTelefono.Text);
            objent.IdRol = Convert.ToInt32(comboBxRol.SelectedValue.ToString());
            objent.Accion = accion;
            string men = objnegr.N_Mantenimiento_Clientes_Admin(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            textUsuario.Text = "";
            textContrasena.Text = "";
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
            dataGridListar.DataSource = objneg.N_Listar_Registados();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mantenimiento("1");
                limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha ingresado ningun dato.");
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mantenimiento("2");
                limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos que modificar.");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mantenimiento("3");
                limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado ningun dato a eliminar.");
            }
            
        }

        private void dataGridListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridListar.CurrentCell.RowIndex;
            textUsuario.Text = dataGridListar[7, fila].Value.ToString();
            textContrasena.Text = dataGridListar[5, fila].Value.ToString();
            txtIdentificacion.Text = dataGridListar[0, fila].Value.ToString();
            txtNombre.Text = dataGridListar[1, fila].Value.ToString();
            txtApellido.Text = dataGridListar[2, fila].Value.ToString();
            textDireccion.Text = dataGridListar[3, fila].Value.ToString();
            textTelefono.Text = dataGridListar[4, fila].Value.ToString();
            comboBxRol.SelectedItem = dataGridListar[6, fila].Value.ToString();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
