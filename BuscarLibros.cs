using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public partial class BuscarLibros : Form
    {
        NegLibros DatosObjAutor = new NegLibros();
        public void CrearDgv()
        {
            DGVBuscarLib.Columns.Add("0", "Id_Libro");
            DGVBuscarLib.Columns.Add("1", "Titulo");
            DGVBuscarLib.Columns.Add("2", "Ubicacion");
            DGVBuscarLib.Columns.Add("3", "Id_Editorial");
            DGVBuscarLib.Columns.Add("4", "Id_Autor");
            DGVBuscarLib.Columns.Add("5", "Id_Genero");
            DGVBuscarLib.Columns.Add("6", "Disponible");


            DGVBuscarLib.Columns[0].Width = 80;
            DGVBuscarLib.Columns[1].Width = 120;
            DGVBuscarLib.Columns[2].Width = 100;
            DGVBuscarLib.Columns[3].Width = 80;
            DGVBuscarLib.Columns[4].Width = 80;
            DGVBuscarLib.Columns[5].Width = 50;
            DGVBuscarLib.Columns[6].Width = 50;
        }
        public BuscarLibros()
        {
            InitializeComponent();
            this.CrearDgv();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBusqueda.Text;
            bool terminoBusquedaValido = DatosObjAutor.EsValidoElTerminoDeBusqueda(busqueda);
            if (terminoBusquedaValido)
            {
                DataSet ds = new DataSet();
                if (rbTitulo.Checked)
                {
                    ds = DatosObjAutor.listadoLibrosBusuqeda(busqueda, "titulo");
                }
                else if (rbUbicacion.Checked)
                {
                    ds = DatosObjAutor.listadoLibrosBusuqeda(busqueda, "ubicacion");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        DGVBuscarLib.Rows.Add(dr[0].ToString(), dr[1]);
                    }
                }
                else
                {
                    MessageBox.Show("No hay autores cargados en la base de datos");
                }
            }
            else
                MessageBox.Show("No se permiten caracteres especiales");
        }
    }
}
