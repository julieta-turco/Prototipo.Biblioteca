using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using capa_Entidades;

namespace capaDatos
{
    public class DatosLibros: DatosConexion
    {
        public int AbmLibros (string accion, Libros objlibros)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = "insert into Libros values " +
               "("+ objlibros.P_IDLibro +",'" + objlibros.P_Titulo + "'," +
               " "+objlibros.P_Ubicacion+", "+objlibros.P_Disponible+", " +
               ""+ objlibros.P_IDAutor+ ", " + objlibros.P_IDEditorial + "," +
               "" + objlibros.P_IDGenero + "); ";
           
            if (accion == "Modificar")
                orden = "update Libros set Título='" + objlibros.P_Titulo + "'where Id_Libro = " + objlibros.P_IDLibro + "; ";
                orden = "update Libros set Ubicacion='" + objlibros.P_Ubicacion + "'where Id_Libro = " + objlibros.P_IDLibro + "; ";
                orden = "update Libros set Disponible='" + objlibros.P_Disponible + "'where Id_Libro = " + objlibros.P_IDLibro + "; ";
                orden = "update Libros set Id_Autor='" + objlibros.P_IDAutor + "'where Id_Libro = " + objlibros.P_IDLibro + "; ";
                orden = "update Libros set Id_Editorial='" + objlibros.P_IDEditorial + "'where Id_Libro = " + objlibros.P_IDLibro + "; ";
                orden = "update Libros set Id_Genero='" + objlibros.P_IDGenero + "'where Id_Libro = " + objlibros.P_IDLibro + "; ";

            if(accion == "Baja")
                orden = "delete Libros get Id_Libros'"+ 
                    objlibros.P_IDLibro + ",'" + objlibros.P_Titulo + "'," +objlibros.P_Ubicacion + ", " + objlibros.P_Disponible + ", "+ objlibros.P_IDAutor + ", " + objlibros.P_IDEditorial + "," +
               "" + objlibros.P_IDGenero + "); ";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar de productos ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;



        }
    }
}
