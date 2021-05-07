using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VentanaLogin
{
    public partial class Emergente : Form
    {
        
        bool val = false;
        public Emergente()
        {
            InitializeComponent();
        }

        //Cambia el mensaje que se presenta en la ventana emergente según el caso: datos correctos o
        //datos incorrectos.
        public void Cambiar_Mensaje_Ingreso()
        {
            txtMensaje.Text = "Login exitoso, bienvenido.";
        }

        //Método que controla el mensaje mostrado.
        public void Cambiar_Mensaje_Corregir()
        {
            txtMensaje.Text = "Los datos son erroneos, por favor verifique.";
            this.btnAceptar.Hide();
        }

        //Método que controla lo que sucede al dar click en el botón aceptar.
        public void btnAceptar_Click(object sender, EventArgs e)
        {
            
            this.Close();
            PrincipalContenedor principal = new PrincipalContenedor();
            principal.AbrirFormulario(new Principal());
            principal.ShowDialog();
            
        }

        
        // Todos los formularios incluyen un pictureBox con el icono de cerrar
        //El siguiente método controla el evento de dar click en la imagen 
        
        private void imagenCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Los siguientes metodos permiten controlar los eventos MouseDown, MouseMove y MouseUp
        //su finalidad es localizar la posición que tiene el mouse cuando se presiona el botón y mientras sigue
        //presionado, todo esto para reubicar la ventana en la última posíción en que está el mouse.
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            val = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (val == true)
            {
                this.Location = Cursor.Position;

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            val = false;
        }

    }
}
