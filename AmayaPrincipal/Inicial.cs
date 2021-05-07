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

namespace AmayaPrincipal
{
    public partial class Inicial : Form
    {
        bool val = false;
        public Inicial()
        {
            InitializeComponent();
        }
        //Método que controla la conexión con la base de datos para la conexión de usuarios.
        private void Logins()
        {
            try
            {
                //Cadena de conexion
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                //Declaramos la instancia de la conexion con la cadena
                using (SqlConnection conexion = new SqlConnection(cnn))
                {

                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        cmdText: "SELECT Usuario, Contrasena FROM Usuarios Where Usuario = '" + txtUsuario.Text + " ' and Contrasena  = '" + txtContrasena.Text + "'",
                        connection: conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            Emergente bienvenido = new Emergente();
                            bienvenido.Cambiar_Mensaje_Ingreso();
                            bienvenido.Show();
                            this.Hide();
                        }
                        else
                        {

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                txtUsuario.Focus();
                Emergente bienvenido = new Emergente();
                bienvenido.Cambiar_Mensaje_Corregir();
                bienvenido.Show();
                MessageBox.Show(Convert.ToString(ex));
            }
        }


        //método que controla el evento de click en el botón ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Logins();

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

        private void Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}
