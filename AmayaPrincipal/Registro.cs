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
    public partial class Registro : Form
    {
        ClassEntidad_Registro objent = new ClassEntidad_Registro();
        ClassNegocio_Registro objneg = new ClassNegocio_Registro();
        bool val = false;
        public Registro()
        {
            InitializeComponent();
        }

        void mantenimiento(string accion)
        {
            objent.Usuario = txtUsuario.Text;
            objent.Contrasena = txtContrasena.Text;
            objent.Identificacion = Convert.ToInt32(txtIdentificacion.Text);
            objent.Nombre = txtNombre.Text;
            objent.Apellido = txtApellido.Text;
            objent.Direccion = txtDireccion.Text;
            objent.Telefono = Convert.ToInt32(txtTelefono.Text);
            objent.Accion = accion;
            string men = objneg.N_Mantenimiento_Clientes(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                mantenimiento("1");
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Verifique los datos ingresados.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            val = true;
        }

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (val == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panelTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            val = false;
        }

    }
}
