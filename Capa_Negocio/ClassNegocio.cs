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
    }
}
