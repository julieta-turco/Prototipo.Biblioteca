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
        private DateTime Fecha;

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
        public bool P_Disponible
        {
            set { Disponible = value; }
            get { return Disponible; }
        }
        public int P_IDAutor
        {
            get { return ID_Autor; }
        }
        public int P_IDEditorial
        {
             get { return ID_Editorial; }
        }
        public int P_IDGenero
        {
            get { return ID_Genero; }
        }
        public DateTime P_Fecha
        {
            set { Fecha = value; }
            get { return Fecha; }
        }
        #endregion
        #region Constructor
        public Libros()
        {
        }
        public Libros(int IdL, string Tit, string Ubi, bool Disp, int IdA, int IdE, int IdG, DateTime fech)
        {
            Id_Libro = IdL;
            Titulo = Tit;
            Ubicacion = Ubi;
            Disponible = Disp;
            ID_Autor = IdA;
            ID_Editorial = IdE;
            ID_Genero = IdG;
            Fecha = fech;
        }
        public Libros(string Tit, string Ubi, bool Disp, int IdA, int IdE, int IdG, DateTime fech)
        {
            Titulo = Tit;
            Ubicacion = Ubi;
            Disponible = Disp;
            ID_Autor = IdA;
            ID_Editorial = IdE;
            ID_Genero = IdG;
            Fecha = fech;
        }
        public Libros(string Tit, string Ubi, bool Disp, DateTime fech)
        {
            Titulo = Tit;
            Ubicacion = Ubi;
            Disponible = Disp;
            Fecha = fech;
        }
        #endregion

    }
}
