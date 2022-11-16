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
    public class AdministrarTablas : DatosConexion
    {
        #region Libros
        public int AbmLibros(string accion, Libros objlibros)
        {
            int resultado = -1; // controlar que se realice la accion
            string orden = string.Empty; // para guardar la consulta sql
            if (accion == "Alta")
            {
                orden = "insert into libros (Titulo, Ubicacion,Id_Editorial, Id_Autor, Id_Genero, Disponible) values('" + objlibros.P_Titulo + "'," +
                "'" + objlibros.P_Ubicacion + "', " + objlibros.P_IdEditorial + ", " + objlibros.P_IdAutor + ", " +
               "" + objlibros.P_IdGenero + ", " + objlibros.P_Disponible + ");";
            }
            if (accion == "Modificar")
            {
                orden = "update libros set Titulo =" + "'" + objlibros.P_Titulo + "'";
                orden += ", Ubicacion = '" + objlibros.P_Ubicacion + "'";
                orden += ", Id_Editorial =" + objlibros.P_IdEditorial;
                orden += ", Id_Autor = " + objlibros.P_IdAutor;
                orden += ", Id_Genero= " + objlibros.P_IdGenero;
                orden += ", Disponible = " + objlibros.P_Disponible;
                orden += " where Id_Libro =" + objlibros.P_IDLibro + ";";
            }
            if (accion == "Baja")
            {
                orden = " delete From Libros where Id_Libro = " + objlibros.P_IDLibro + ";";
            }
            
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar el registro ", e);
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

            if (cual != "todos")
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
                throw new Exception("Error al listar los libros", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        #endregion
        #region Editorial
        public List<Editorial> ObtenerEditorial()
        {
            List<Editorial> lista = new List<Editorial>();
            string orden = "Select Id_Editorial, Nombre From Editorial";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            OleDbDataReader dr;
            try
            {
                Abrirconexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Editorial E = new Editorial();
                    E.P_IdEditorial = dr.GetInt32(0);
                    E.P_Nombre = dr.GetString(1);
                    lista.Add(E);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Editoriales", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return lista;
        }

        public int AbmEditorial(string accion, Editorial objeditorial)
        {
            int resultado = -1; // controlar que se realice la accion
            string orden = string.Empty; // para guardar la consulta sql
            if (accion == "Alta")

                orden = "insert into Editorial (Nombre, Direccion, Telefono, Mail) values('" + objeditorial.P_Nombre + "'," +
               "'" + objeditorial.P_Direccion + "', " + objeditorial.P_Numero + ", " +
               "' " + objeditorial.P_Mail + "'); ";

            if (accion == "Modificar")
            {
                orden = "update Editorial set Nombre='" + objeditorial.P_Nombre + "'";
                orden += ", Direccion='" + objeditorial.P_Direccion + "'";
                orden += ", Telefono =" + objeditorial.P_Numero;
                orden += ", Mail='" + objeditorial.P_Mail + "'";
                orden += " where Id_editorial= " + objeditorial.P_IdEditorial + ";";

            }

            if (accion == "Baja")
                orden = "delete From Editorial where Id_Editorial = " + objeditorial.P_IdEditorial + ";";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar el registro ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;

        }
        public DataSet listadoEditoriales(string cual)
        {
            string orden = string.Empty;

            if (cual != "todos")
                orden = "select * from editorial where Id_editorial = " + int.Parse(cual) + ";";
            else
                orden = "select * from editorial;";

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
                throw new Exception("Error al listar las editoriales", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;

        }
        #endregion
        #region Autor
        public List<Autor> ObtenerAutor()
        {
            List<Autor> lista = new List<Autor>();
            string orden = "Select Id_Autor, NombreApellido From Autor";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            OleDbDataReader dr;
            try
            {
                Abrirconexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Autor A = new Autor();// instancio R como un objeto Rubro
                    A.P_IDAutor = dr.GetInt32(0); //se puede acceder a los campos con el tipo de dato, en este caso un entero
                    A.P_NombreApellido = dr.GetString(1);
                    lista.Add(A);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Autores", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return lista;
        }
        public int AbmAutor(string accion, Autor objautor)
        {
            int resultado = -1; // controlar que se realice la accion
            string orden = string.Empty; // para guardar la consulta sql
            if (accion == "Alta")

                orden = "insert into Autor (NombreApellido) values " + " ('" + objautor.P_NombreApellido + "');";


            if (accion == "Modificar")
            {
                orden = "update Autor set NombreApellido='" + objautor.P_NombreApellido + "'";
                orden += " where Id_Autor= " + objautor.P_IDAutor + ";";
            }

            if (accion == "Baja")
                orden = "delete From Autor where Id_Autor = " + objautor.P_IDAutor + ";";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar el registro ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }
        public DataSet listadoAutores(string cual)
        {
            string orden = string.Empty;

            if (cual != "todos")
                orden = "select * from autor where Id_autor = " + int.Parse(cual) + ";";
            else
                orden = "select * from autor;";

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
                throw new Exception("Error al listar los autores", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        #endregion
        #region Genero
        public List<Genero> ObtenerGenero()
        {
            List<Genero> lista = new List<Genero>();
            string orden = "Select Id_Genero, NombreGenero From Genero ";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            OleDbDataReader dr;
            try
            {
                Abrirconexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Genero G = new Genero();// instancio R como un objeto Rubro
                    G.P_IDGenero = dr.GetInt32(0); //se puede acceder a los campos con el tipo de dato, en este caso un entero
                    G.P_NombreGenero = dr.GetString(1);
                    lista.Add(G);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Generos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return lista;
        }
        public int AbmGenero(string accion, Genero objgenero)
        {
            int resultado = -1; // controlar que se realice la accion
            string orden = string.Empty; // para guardar la consulta sql
            if (accion == "Alta")
                orden = "insert into Genero (NombreGenero) values(" + "'" + objgenero.P_NombreGenero + "');";

            if (accion == "Modificar")
            {
                orden = "update Genero set NombreGenero='" + objgenero.P_NombreGenero + "'";
                orden += " where Id_Genero=" + objgenero.P_IDGenero + ";";
            }
            if (accion == "Baja")
                orden = "delete From Genero where Id_Genero = " + objgenero.P_IDGenero + ";";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar el registro ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }
        public DataSet listadoGeneros(string cual)
        {
            string orden = string.Empty;

            if (cual != "todos")
                orden = "select * from genero where Id_genero = " + int.Parse(cual) + ";";
            else
                orden = "select * from genero;";

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
                throw new Exception("Error al listar los generos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        #endregion

    }
}
