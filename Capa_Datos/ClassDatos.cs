using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{
    public class ClassDatos_Login
    { 
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

            
            public DataTable D_Cliente_Login(ClassEntidad_Login obje)
            {
                SqlCommand cmd = new SqlCommand("sp_logueo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", obje.Usuario);
                cmd.Parameters.AddWithValue("@Contrasena", obje.Contrasena);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
    }
    
    public class ClassDatos_Registro
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public string D_Mantenimiento_Clientes(ClassEntidad_Registro obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_Mantenimiento_Clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", obje.Usuario);
            cmd.Parameters.AddWithValue("@Contrasena", obje.Contrasena);
            cmd.Parameters.AddWithValue("@Identificacion", obje.Identificacion);
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", obje.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", obje.Telefono);
            cmd.Parameters.AddWithValue("@Direccion", obje.Direccion);
            cmd.Parameters.Add("@Accion", SqlDbType.VarChar, 50).Value = obje.Accion;
            cmd.Parameters["@Accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@Accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    }
     
    public class ClassDatos_Producto
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable D_Buscar_Producto(ClassEntidad_Producto obje)
        {
            SqlCommand cmd = new SqlCommand("sp_Buscar_Producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre_Producto", obje.Nombre_Producto);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string D_Mantenimiento_Producto(ClassEntidad_Producto obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_Actualizar_Producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre_Producto);
            cmd.Parameters.AddWithValue("@Cantidad", obje.Cantidad);
            cmd.Parameters.Add("@Accion", SqlDbType.VarChar, 50).Value = obje.Accion;
            cmd.Parameters["@Accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@Accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    }
}
