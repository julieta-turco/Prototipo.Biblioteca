using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_Entidades
{
    public class Autor
    {
        #region atributos
        private int Id_Autor;
        private string NombreApellido;
        #endregion

        #region Propiedades
        public int P_IDAutor
        {
            set { Id_Autor = value; }
            get { return Id_Autor; }
        }
        public string P_NombreApellido
        {
            set { NombreApellido = value; }
            get { return NombreApellido; }
        }
        #endregion

        #region Contructor
        public Autor()
        {
        }
        public Autor(int IdA, string NomApe)
        {
            Id_Autor = IdA;
            NombreApellido = NomApe;
        }
        public Autor(string NomApe)
        {
            NombreApellido = NomApe;
        }

        #endregion
    }
}
