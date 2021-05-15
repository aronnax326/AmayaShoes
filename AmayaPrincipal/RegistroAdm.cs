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

namespace AmayaPrincipal
{
    public partial class RegistroAdm : Form
    {
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
    }
}
