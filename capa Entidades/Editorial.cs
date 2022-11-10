using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_Entidades
{
    class Editorial
    {
        
        private int Id_Editorial;
        private string Nombre;
        private string Direccion;
        private long Numero;
        private string Mail;

        #region propiedades
        public int P_IdEditorial
        {
            get { return Id_Editorial; }
        }
        public string P_Nombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public string P_Direccion
        {
            set { Direccion = value; }
            get { return Direccion; }
        }
        public long P_Numero
        {
            set { Numero = value; }
            get { return Numero; }
        }
        public string P_Mail
        {
            set { Mail = value; }
            get { return Mail; }
        }
        #endregion

        #region Constructor
        public Editorial()
        {
        }
        public Editorial(int IdE, string Nome, string Dire, int Num, string Email)
        {
            Id_Editorial = IdE;
            Nombre = Nome;
            Direccion = Dire;
            Numero = Num;
            Mail = Email;
        }
        public Editorial(string nome)
        {
            Nombre = nome;
        }
        #endregion
    }
}
