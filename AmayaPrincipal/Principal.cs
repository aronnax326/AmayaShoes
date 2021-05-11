using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmayaPrincipal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //Método que controla el objeto Timer y muestra fecha y hora actual del momento de ejecución.
        private void RelojFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        
    }
}
