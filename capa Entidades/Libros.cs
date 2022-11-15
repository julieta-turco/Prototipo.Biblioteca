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
        
        private int Id_Libro;
        private string Titulo;
        private string Ubicacion;
        private bool Disponible;
        private int ID_Autor;
        private int ID_Editorial;
        private int ID_Genero;

        #endregion

        #region propiedades
        public int P_IDLibro
        {
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
        public int P_IdAutor
        {
            get { return ID_Autor; }
        }
        public int P_IdEditorial
        {
             get { return ID_Editorial; }
        }
        public int P_IdGenero
        {
            get { return ID_Genero; }
        }
        public bool P_Disponible
        {
            set { Disponible = value; }
            get { return Disponible; }
        }
        #endregion
        #region Constructor
        public Libros()
        {
        }
        public Libros(int IdL, string Tit, string Ubi, int IdA, int IdE, int IdG, bool Disp)
        {
            Id_Libro = IdL;
            Titulo = Tit;
            Ubicacion = Ubi;
            ID_Autor = IdA;
            ID_Editorial = IdE;
            ID_Genero = IdG;
            Disponible = Disp;

        }
        public Libros(string Tit, string Ubi, int IdA, int IdE, int IdG, bool Disp)
        {
            Titulo = Tit;
            Ubicacion = Ubi;
            ID_Autor = IdA;
            ID_Editorial = IdE;
            ID_Genero = IdG;
            Disponible = Disp;

        }
        public Libros(string Tit, string Ubi, bool Disp)
        {
            Titulo = Tit;
            Ubicacion = Ubi;
            Disponible = Disp;

        }
        #endregion

    }
}
