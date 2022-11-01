using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_Entidades
{
    class claseGenero
    {  
        {
        private
            int Id_Genero;
         string Genero;

        #region Propiedades
        public int P_IDGenero
        {
            set { Id_Genero = value; }
            get { return Id_Genero; }
        }
        public string P_Generito
        {
            set { Genero = value; }
            get { return Genero; }
        }
        #endregion

        #region Constructor
        public claseGenero()
        {
        }
        public claseGenero(int IdG, string Gen, string Ape)
        {
            Id_Genero = IdG;
            Genero = Gen;
        }
        #endregion
    }
}
