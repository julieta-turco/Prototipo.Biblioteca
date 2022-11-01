using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_Entidades;
using capa_Datos;


namespace capaPresentacion
{
    public partial class formLibros : Form
    {
        Libros NuevoLibro;
        Libros LibrosExistente;
        //NegLibros objNegProducto = new NegLibros();
        bool nuevo = true;
        //int fila;

        public formLibros()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            formListaLibros formLL = new formListaLibros();
            formLL.Show();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
