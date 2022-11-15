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
using capaDatos;
using CapaNegocio;

namespace capaPresentacion
{
    public partial class formGenero : Form
    {
        Genero AltaGenero;
        Genero GeneroExistente;
        NegLibros DatosObjGenero = new NegLibros();
        public formGenero()
        {
            InitializeComponent();
            CrearDgv();
            LlenarDgv();
        }
        public void LlenarDgv()
        {
            DGV_Genero.Rows.Clear();
            DataSet ds = new DataSet();
            ds = DatosObjGenero.listadoGeneros("todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DGV_Genero.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }
            else
            {
                MessageBox.Show("No hay generos cargados en la base de datos");
            }
        }
        public void CrearDgv()
        {
            DGV_Genero.Columns.Add("0", "Id_Genero");
            DGV_Genero.Columns.Add("1", "NombreGenero");
        }
        private void Btn_IngresarGen_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            AltaGenero = new Genero(TxtB_NomGenero.Text);

            nGrabados = DatosObjGenero.AbmGenero("Alta", AltaGenero);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el genero en el sistema");
            }
            else
            {
                LlenarDgv();
            }

        }

        private void Btn_SalirGen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_SelecGen_Click(object sender, EventArgs e)
        {
            TxtB_NomGenero.Text = DGV_Genero.Rows[DGV_Genero.CurrentRow.Index].Cells[1].Value.ToString();

        }

        private void Btn_ModificarGen_Click(object sender, EventArgs e)
        {
            GeneroExistente = new Genero(int.Parse(DGV_Genero.Rows[DGV_Genero.CurrentRow.Index].Cells[0].Value.ToString()), TxtB_NomGenero.Text);

            int nResultado = -1;
            nResultado = DatosObjGenero.AbmGenero("Modificar", GeneroExistente);
            if (nResultado != -1)
            {
                LlenarDgv();
            }
            else
            {
                MessageBox.Show("se produjo un error al modificar el genero");
            }
        }

        private void Btn_EliminarGen_Click(object sender, EventArgs e)
        {
            GeneroExistente = new Genero(int.Parse(DGV_Genero.Rows[DGV_Genero.CurrentRow.Index].Cells[0].Value.ToString()), TxtB_NomGenero.Text);

            int nResultado = -1;
            nResultado = DatosObjGenero.AbmGenero("Baja", GeneroExistente);
            if (nResultado != -1)
            {
                LlenarDgv();
            }
            else
            {
                MessageBox.Show("se produjo un error al eliminar el genero");
            }
        }
    }
}
