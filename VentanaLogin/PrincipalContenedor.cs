using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace VentanaLogin
{
    public partial class PrincipalContenedor : Form
    {
        //Variable que contiene la ruta del audio y es de tipo SoundPlayer
        SoundPlayer reproductor = new SoundPlayer(@"C:\Users\slope\OneDrive\Sena\Semana 16\Persona 5 OST 09 - Beneath the Mask -instrumental version-.wav");
        bool val = false;
        public PrincipalContenedor()
        {
            InitializeComponent();
        }


      //Método que controla el evento click sobre el pictureBox con el icono cerrar
        private void Imagen_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        //Botón que controla el inicio de la reproducción del archivo de audio
        private void btnPlay_Click(object sender, EventArgs e)
        {

            reproductor.Play();
        }

        //Botón que controla el fin la reproducción del archivo de audio
        private void btnStop_Click(object sender, EventArgs e)
        {
            reproductor.Stop();
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
            if (val == true) this.Location = Cursor.Position;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            val = false;
        }

        //Botón que permite cerrar la aplicación
        private void btnSalirPanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Agrega un Form dentro de un panel para mostrarlo integrado, recibe como parametro un formulario creado
        // y crea un formulario igual pero que es encajado en el panel
        public void AbrirFormulario(Form hijo)
        {
            if (this.panelTema.Controls.Count > 0) this.panelTema.Controls.RemoveAt(0);
            Form fh = hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelTema.Controls.Add(fh);
            this.panelTema.Tag = fh;
            fh.Show();

        }

        //Botón que permite regresar a la pantalla principal
        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Principal());
        }

        //Botón que permite cambiar a la pantalla catalogo
        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Catalogo());
        }

        //Botón que permite cambiar a la pantalla carrito
        private void btnCarrito_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Carrito());
        }

        //Botón que permite cambiar a la pantalla eventos
        private void btnEventos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Eventos());
        }
    }   
}
