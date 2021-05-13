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
    public partial class Pedidos : Form
    {
        ClassEntidad_Clientes objent = new ClassEntidad_Clientes();
        ClassNegocio_Clientes objneg = new ClassNegocio_Clientes();
        ClassEntidad_Producto objentp = new ClassEntidad_Producto();
        ClassNegocio_Producto objnegp = new ClassNegocio_Producto();
        ClassEntidad_Pedido objentped = new ClassEntidad_Pedido();
        ClassNegocio_Pedido objnegped = new ClassNegocio_Pedido();
        ClassEntidad_Detalle objentdet = new ClassEntidad_Detalle();
        ClassNegocio_Detalle objnegdet = new ClassNegocio_Detalle();
        
        
        public Pedidos()
        {
            InitializeComponent();
            
        }

        void mantenimiento_pedido(string accion)
        {
            objentped.Numero_Pedido = Convert.ToInt32(textNumPedido.Text);
            objentped.Identificacion = Convert.ToInt32(textIdentificacion.Text);
            objentped.Fecha = Convert.ToDateTime(textFecha.Text);
            objentped.Nombre_Producto = textNomProducto.Text;
            objentped.Cantidad = Convert.ToInt32(textCantidad.Text);
            objentped.Accion = accion;
            string men = objnegped.N_Mantenimiento_Pedido(objentped);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void mantenimiento_detalle(string accion)
        {
            objentdet.Numero_Pedido = Convert.ToInt32(textNumPedido.Text);
            objentdet.Codigo = textCodigo.Text;
            objentdet.Cantidad = Convert.ToInt32(textCantidad.Text);
            objentdet.Accion = accion;
            string men = objnegdet.N_Mantenimiento_Detalle(objentdet);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

       public void Generar_Numero_Pedido()
        {
            Random pedido = new Random();
            int numeroPed = pedido.Next(0, 1000);
            textNumPedido.Text = Convert.ToString(numeroPed);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(textIdentificacion.Text != "")
            {
                Generar_Numero_Pedido();
                objent.Identificacion = Convert.ToInt32(textIdentificacion.Text);
                DataTable dt = new DataTable();
                dt = objneg.N_Buscar_Clientes(objent);
                dataGridViewListar.DataSource = dt;
                textNombre.Text = dataGridViewListar[0, 0].Value.ToString();
                textApellido.Text = dataGridViewListar[1, 0].Value.ToString();
                textDireccion.Text = dataGridViewListar[2, 0].Value.ToString();
                textTelefono.Text = dataGridViewListar[3, 0].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero de identificación");
            }


        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            mantenimiento_pedido("1");
            objentped.Numero_Pedido= Convert.ToInt32(textNumPedido.Text);
            DataTable dt = new DataTable();
            dt = objnegped.N_Buscar_Pedido(objentped);
            dataGridViewPedido.DataSource = dt;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            mantenimiento_detalle("1");
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {
            if (textCodigo.Text != "")
            {
                objentp.Codigo = textCodigo.Text;
                DataTable dt = new DataTable();
                dt = objnegp.N_Buscar_Producto(objentp);
                dataGridViewProd.DataSource = dt;
                textNomProducto.Text = dataGridViewProd[0, 0].Value.ToString();
            }
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            textFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            Fecha.Enabled = true;
        }
    }
}
