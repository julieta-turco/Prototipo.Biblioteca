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
    public class DatosLibros : DatosConexion
    {
        public int AbmLibros(string accion, Libros objlibros)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = "insert into Libros values " +
               "(" + objlibros.P_IDLibro + ",'" + objlibros.P_Titulo + "'," +
               " " + objlibros.P_Ubicacion + ", " + objlibros.P_Disponible + ", " +
               "" + objlibros.P_IDAutor + ", " + objlibros.P_IDEditorial + "," +
               "" + objlibros.P_IDGenero + "); ";

            if (accion == "Modificar")
            orden = "update Libros set Título='" + objlibros.P_Titulo + "'";
            orden += ", Ubicacion =" + objlibros.P_Ubicacion;
            orden += ", Disponible='" + objlibros.P_Disponible;
            orden += ", Id_Autor='" + objlibros.P_IDAutor;
            orden += ", Id_Editorial='" + objlibros.P_IDEditorial;
            orden += ", Id_Genero='" + objlibros.P_IDGenero;
            orden += "'where Id_Libro = " + objlibros.P_IDLibro + "; ";

            if (accion == "Baja")
                orden = "delete Libros get Id_Libros'" +
                    objlibros.P_IDLibro + ",'" + objlibros.P_Titulo + "'," + objlibros.P_Ubicacion + ", " + objlibros.P_Disponible + ", " + objlibros.P_IDAutor + ", " + objlibros.P_IDEditorial + "," +
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

        public DataSet listadoLibros(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Libros where Id_Libro = " + int.Parse(cual) + ";";
            else
                orden = "select * from Libros;";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar productos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;


        }
    }
}
