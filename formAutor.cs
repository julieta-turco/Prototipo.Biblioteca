using capa_Entidades;
using CapaNegocio;
using capaPresentacion;
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
    public partial class formAutor : Form
    {
        Autor NuevoAutor;
        Autor AutorExistente;
        NegLibros DatosObjAutor = new NegLibros();
        public formAutor()
        {
            InitializeComponent();
            CrearDgv();
            LlenarDgv();
        }

        public void LlenarDgv()
        {
            DGVAut.Rows.Clear();
            DataSet ds = new DataSet();
            ds = DatosObjAutor.listadoAutores("todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DGVAut.Rows.Add(dr[0].ToString(), dr[1], dr[2]);
                }
            }
            else
            {
                MessageBox.Show("No hay autores cargados en la base de datos");
            }
        }

        public void CrearDgv()
        {
            DGVAut.Columns.Add("0", "Id_Autor");
            DGVAut.Columns.Add("1", "Nombre y Apellido");
            //dataGridView_autores.Columns.Add("2", "Apellido");
        }
        private void Btn_AgregarAut_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            //Autor NuevoAutor;
            NuevoAutor = new Autor(TxtBNomApeAut.Text);

            //NegLibros DatosObjAutor = new NegLibros();

            nGrabados = DatosObjAutor.AbmAutor("Alta", NuevoAutor);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el autor en el sistema");
            }
            else
            {
                LlenarDgv();
            }
        }

        private void Btn_SalirAut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSelecAut_Click(object sender, EventArgs e)
        {
            TxtBNomApeAut.Text = DGVAut.Rows[DGVAut.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void Btn_ModificarAut_Click(object sender, EventArgs e)
        {
            AutorExistente = new Autor(int.Parse(DGVAut.Rows[DGVAut.CurrentRow.Index].Cells[0].Value.ToString()), TxtBNomApeAut.Text);


            int nResultado = -1;
            nResultado = DatosObjAutor.AbmAutor("Modificar", AutorExistente);
            if (nResultado != -1)
            {
                LlenarDgv();
            }
            else
            {
                MessageBox.Show("se produjo un error al modificar el autor");
            }
        }

        private void Btn_EliminarAut_Click(object sender, EventArgs e)
        {
            AutorExistente = new Autor(int.Parse(DGVAut.Rows[DGVAut.CurrentRow.Index].Cells[0].Value.ToString()), TxtBNomApeAut.Text);


            int nResultado = -1;
            nResultado = DatosObjAutor.AbmAutor("Baja", AutorExistente);
            if (nResultado != -1)
            {
                LlenarDgv();
            }
            else
            {
                MessageBox.Show("se produjo un error al modificar el autor");
            }
        }
    }
}
