using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;

namespace capaPresentacion
{
    public partial class PPrin : Form
    {
        public PPrin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGenero frm = new formGenero();
            frm.Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            formLibros frmLib = new formLibros();
            frmLib.Show();
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
