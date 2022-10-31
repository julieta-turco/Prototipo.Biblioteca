using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_Entidades
{
    class Libros
    {
        #region atributos
        protected
            int ID_libro;
        string Titulo;
        string Ubicacion;
        DateTime fechaIng = new DateTime();
        int ID_Autor;
        int ID_Editorial;
        bool ID_Estado;
        #endregion
    }
    class Autor
    {
    }
    class Genero
    {
    }
}
