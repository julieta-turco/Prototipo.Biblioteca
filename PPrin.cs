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
using CapaNegocio;

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
            this.Close();
            formLibros frmLib = new formLibros();
            frmLib.Show();
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NegocioLibros PruebaConexion = new NegocioLibros();
            if (PruebaConexion.EstablecerConexion())
                MessageBox.Show("Conexion Exitosa");
            else MessageBox.Show("Fallo la Conexion");
        }
    }
}
