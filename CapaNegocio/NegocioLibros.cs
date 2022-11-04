using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_Entidades;
using capaDatos;

namespace CapaNegocio
{
    public class NegocioLibros
    {
        public bool EstablecerConexion()
        {
            DatosConexion pruebaconexion = new DatosConexion();
            bool Exitoso = pruebaconexion.Abrirconexion();
            pruebaconexion.Cerrarconexion();

            return Exitoso;
        }
        DatosLibros objetoDatosLibros = new DatosLibros();

        public int AbmLibros(string accion, Libros objlibros)
        {
            return objetoDatosLibros.AbmLibros(accion, objlibros);
        }
        public DataSet listadoLibros(string cual)
        {
            return objetoDatosLibros.listadoLibros(cual);
        }
    }
   
}
