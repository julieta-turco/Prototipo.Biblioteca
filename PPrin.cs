using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Entidades;

namespace capaPresentacion
{
    public partial class PPrin : Form
    {
        public PPrin()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLibros frmLibs = new formLibros();
            frmLibs.Show();
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            if (negocio.probarConexion())
            {
                MessageBox.Show("Conexion exitosa");
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }
        }

        private void editorialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formEditorial frm = new formEditorial();
            frm.Show();
        }

        private void generoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formGenero frm = new formGenero();
            frm.Show();
        }

        private void autorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formAutor frm = new formAutor();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarLibros frm = new BuscarLibros();
            frm.Show();
        }
    }
}
