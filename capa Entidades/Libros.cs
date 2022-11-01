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

        #region Metodos

        #endregion
    }
    //public class Autor
    //{
    //    #region atributos
    //    protected int Id_Autor;
    //    protected string Nombre;
    //    protected string Apellido;
    //    #endregion

    //    #region Propiedades
    //    public int P_IDAutor
    //    {
    //        set { Id_Autor = value; }
    //        get { return Id_Autor; }
    //    }
    //    public string P_Nombre
    //    {
    //        set { Nombre = value; }
    //        get { return Nombre; }
    //    }
    //    public string P_Apellido
    //    {
    //        set { Apellido = value; }
    //        get { return Apellido; }
    //    }
    //    #endregion

    //    #region Contructor
    //    public Autor()
    //    {
    //    }
    //    public Autor(int IdA, string Nom, string Ape )
    //    {
    //        Id_Autor = IdA;
    //        Nombre = Nom;
    //        Apellido = Ape;
    //    }
    //    #endregion
    //}
    //public class Genero
    //{
    //    protected int Id_Genero;
    //    protected string Generito;

    //    #region Propiedades
    //    public int P_IDGenero
    //    {
    //        set { Id_Genero = value; }
    //        get { return Id_Genero; }
    //    }
    //    public string P_Generito
    //    {
    //        set { Generito = value; }
    //        get { return Generito; }
    //    }
    //    #endregion

    //    #region Constructor
    //    public Genero()
    //    {
    //    }
    //    public Genero(int IdG, string Gen, string Ape)
    //    {
    //        Id_Genero = IdG;
    //        Generito = Gen;
    //    }
    //    #endregion

    //}

}
