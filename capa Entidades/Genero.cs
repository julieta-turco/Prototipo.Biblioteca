using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_Entidades
{
    public class Genero
    {
        private int Id_Genero;
        private string NombreGenero;

        #region Propiedades
        public int P_IDGenero
        {
            set { Id_Genero = value; }
            get { return Id_Genero; }
        }
        public string P_NombreGenero
        {
            set { NombreGenero = value; }
            get { return NombreGenero; }
        }
        #endregion

        #region Constructor
        public Genero()
        {
        }
        public Genero(int IdG, string Gen)
        {
            Id_Genero = IdG;
            NombreGenero = Gen;
        }
        public Genero(string Gen)
        {
            NombreGenero = Gen;
        }
        #endregion
    }
}
