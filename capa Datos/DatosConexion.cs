using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace capaDatos
{
    public class DatosConexion
    {
        protected OleDbConnection conexion;
        protected string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\juli_\OneDrive\Escritorio\source\repos\Base de Datos - Biblioteca.accdb";
        
        public DatosConexion()
        {
            conexion = new OleDbConnection(cadenaConexion);
        }
        public bool Abrirconexion()
        {
            bool Exitoso = false;
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
                Exitoso = true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
                
            }
            return Exitoso;
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }
}
