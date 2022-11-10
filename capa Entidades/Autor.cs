using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_Entidades
{
    class Autor
    {
        #region atributos
        private int Id_Autor;
        private string Nombre;
        private string Apellido;
        #endregion

        #region Propiedades
        public int P_IDAutor
        {
            get { return Id_Autor; }
        }
        public string P_Nombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public string P_Apellido
        {
            set { Apellido = value; }
            get { return Apellido; }
        }
        #endregion

        #region Contructor
        public Autor()
        {
        }
        public Autor(int IdA, string Nom, string Ape)
        {
            Id_Autor = IdA;
            Nombre = Nom;
            Apellido = Ape;
        }

        #endregion
    }
}
