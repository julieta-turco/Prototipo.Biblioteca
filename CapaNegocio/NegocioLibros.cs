using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_Entidades;
using capaDatos;

namespace CapaNegocio
{
    public class NegLibros
    {
        #region Libros
        AdministrarTablas DatosObjLibros = new AdministrarTablas();
        public int AbmLibros(string accion, Libros objlibros)
        {
            return DatosObjLibros.AbmLibros(accion, objlibros);
        }

        public DataSet listadoLibros(string cual)
        {
            return DatosObjLibros.listadoLibros(cual);
        }

        public DataSet listadoLibrosBusuqeda(string cual, string tipo)
        {
            return DatosObjLibros.listadoLibrosBusqueda(cual,tipo);                
        }

        public Boolean EsValidoElTerminoDeBusqueda(string terminoBusqueda)
        {
            Boolean esValid = true;
            foreach (char letra in terminoBusqueda)
            {
                if (!char.IsLetterOrDigit(letra))
                    esValid = false;
            }
            return esValid;
        }

        #endregion
        #region Autor
        AdministrarTablas DatosObjAutor = new AdministrarTablas();

        public int AbmAutor(string accion, Autor objautor)
        {
            return DatosObjAutor.AbmAutor(accion, objautor);
        }
        public DataSet listadoAutores(string cual)
        {
            return DatosObjAutor.listadoAutores(cual);
        }
        public List<Autor> ObtenerAutor()
        {

            return DatosObjAutor.ObtenerAutor();
        }
        #endregion
        #region Editorial
        AdministrarTablas DatosObjEditorial = new AdministrarTablas();
        public int AbmEditorial(string accion, Editorial objeditorial)
        {
            return DatosObjEditorial.AbmEditorial(accion, objeditorial);
        }

        public DataSet listadoEditoriales(string cual)
        {
            return DatosObjEditorial.listadoEditoriales(cual);
        }
        public List<Editorial> ObtenerEditorial()
        {
            return DatosObjEditorial.ObtenerEditorial();
        }
        #endregion
        #region Genero
        AdministrarTablas DatosObjGenero = new AdministrarTablas();

        public int AbmGenero(string accion, Genero objgenero)
        {
            return DatosObjGenero.AbmGenero(accion, objgenero);
        }

        public DataSet listadoGeneros(string cual)
        {
            return DatosObjGenero.listadoGeneros(cual);
        }
        public List<Genero> ObtenerGenero()
        {

            return DatosObjGenero.ObtenerGenero();
        }
        #endregion

    }
}
