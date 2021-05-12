using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ClassEntidad_Login
    {
        public String Usuario { get; set; }
        public String Contrasena { get; set; }
    }

    public class ClassEntidad_Registro
    {
        public String Usuario { get; set; }
        public String Contrasena { get; set; }
        public int  Identificacion { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Genero { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
        public String Accion { get; set; }
    }

    public class ClassEntidad_Producto
    {
        public String Nombre_Producto { get; set; }
        public int Cantidad { get; set }
        public String Accion { get; set; }
    }
}
