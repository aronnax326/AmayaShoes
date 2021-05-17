using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;


namespace AmayaPrincipal
{
    public partial class Inicial : Form
    {
        bool val = false;
        ClassEntidad_Login objeClientes = new ClassEntidad_Login();
        ClassNegocio_Login objnClientes = new ClassNegocio_Login();
        public static string nombre_usuario;
        public Inicial()
        {
            InitializeComponent();
        }
        //Método que controla la conexión con la base de datos para la conexión de usuarios.
        private void Logins()
        {
            DataTable dt = new DataTable();
            objeClientes.Usuario = txtUsuario.Text;
            objeClientes.Contrasena = txtContrasena.Text;
            dt = objnClientes.N_Cliente(objeClientes);
            if (dt.Rows.Count != 0)
            {
                Emergente nueva = new Emergente();
                nueva.Cambiar_Mensaje_Ingreso();
                nueva.Show();
                this.Hide();
            }
            else if (dt.Rows.Count == 0)
            {
                Emergente nueva = new Emergente();
                nueva.Cambiar_Mensaje_Corregir();
                nueva.Show();
            }
        }


        //Método que controla el evencto de click sobre el botón salir
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que controla el evento de dar click en el pictureBox que contiene el icono cerrar
        private void Imagen_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Los siguientes métodos controlan el movimiento de la ventana a través
        //de los eventos MouseDown, MouseMove y MouseUp
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

        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

        }


        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            Logins();
        }

        private void lnkLblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro nueva = new Registro();
            nueva.Show();
            
            
        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}
