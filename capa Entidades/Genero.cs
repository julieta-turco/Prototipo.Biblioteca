﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_Entidades
{
    class Genero
    {
        protected int Id_Genero;
        protected string Generito;

        #region Propiedades
        public int P_IDGenero
        {
            set { Id_Genero = value; }
            get { return Id_Genero; }
        }
        public string P_Generito
        {
            set { Generito = value; }
            get { return Generito; }
        }
        #endregion

        #region Constructor
        public Genero()
        {
        }
        public Genero(int IdG, string Gen, string Ape)
        {
            Id_Genero = IdG;
            Generito = Gen;
        }
        #endregion
    }
}
