using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_Entidades
{
   public class Libros
    {
        #region atributos
        protected
            int Id_Libro;
        string Titulo;
        string Ubicacion;
        bool Disponible;
        int ID_Autor;
        int ID_Editorial;
        int ID_Genero;
        #endregion

        #region propiedades
        public int P_IDLibro
        {
            set { Id_Libro = value; }
            get { return Id_Libro; }
        }
        public string P_Titulo
        {
            set { Titulo = value; }
            get { return Titulo; }
        }
        public string P_Ubicacion
        {
            set { Ubicacion = value; }
            get { return Ubicacion; }
        }
        public bool P_Disponible
        {
            set { Disponible = value; }
            get { return Disponible; }
        }
        public int P_IDAutor
        {
            set { ID_Autor = value; }
            get { return ID_Autor; }
        }
        public int P_IDEditorial
        {
            set { ID_Editorial = value; }
            get { return ID_Editorial; }
        }
        public int P_IDGenero
        {
            set { ID_Genero = value; }
            get { return ID_Genero; }
        }
        #endregion
        #region Constructor
        public Libros()
        {
        }
        public Libros(int IdL, string Tit, string Ubi, bool Disp )
        {
            Id_Libro = IdL;
            Titulo = Tit;
            Ubicacion = Ubi;
            Disponible = Disp;
        }
        #endregion

    }
}
