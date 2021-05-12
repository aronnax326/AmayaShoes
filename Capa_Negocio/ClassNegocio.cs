using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using Capa_Entidad;



namespace Capa_Negocio
{
    public class ClassNegocio_Login
    {
        ClassDatos_Login objd = new ClassDatos_Login();
        public DataTable N_Cliente(ClassEntidad_Login obje)
        {
            return objd.D_Cliente_Login(obje);
        }
    }
    public class ClassNegocio_Registro
    {
        ClassDatos_Registro objd = new ClassDatos_Registro();
        public string N_Mantenimiento_Clientes(ClassEntidad_Registro obje)
        {
            return objd.D_Mantenimiento_Clientes(obje);
        }
    }

    public class ClassNegocio_Producto
    {
        ClassDatos_Producto objd = new ClassDatos_Producto();
        public DataTable N_Buscar_Producto(ClassEntidad_Producto obje)
        {
            return objd.D_Buscar_Producto(obje);
        }

        public string N_Mantenimiento_Producto(ClassEntidad_Producto obje)
        {
            return objd.D_Mantenimiento_Producto(obje);
        }
    }
}
