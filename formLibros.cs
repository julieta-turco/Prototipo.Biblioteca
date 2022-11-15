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
using CapaNegocio;
using Entidades;
using capaDatos;

namespace capaPresentacion
{
    public partial class formLibros : Form
    {
        Libros NuevoLibro;
        Libros LibrosExistente;
        NegLibros DatosObjLibros = new NegLibros();
        bool nuevo = true;
        //int fila;

        public formLibros()
        {
            InitializeComponent();
            CrearDgv();
            LlenarDgv();
            LlenarCombos();
        }

        public void CrearDgv()
        {
            DGV_ListaLibros.Columns.Add("0", "Titulo");
            DGV_ListaLibros.Columns.Add("1", "Ubicacion");
            DGV_ListaLibros.Columns.Add("2", "Id_Autor");
            DGV_ListaLibros.Columns.Add("3", "Id_Editorial");
            DGV_ListaLibros.Columns.Add("4", "Id_Genero");
            DGV_ListaLibros.Columns.Add("5", "Disponible");


            DGV_ListaLibros.Columns[0].Width = 200;
            DGV_ListaLibros.Columns[1].Width = 100;
            DGV_ListaLibros.Columns[2].Width = 100;
            DGV_ListaLibros.Columns[3].Width = 80;
            DGV_ListaLibros.Columns[4].Width = 80;
            DGV_ListaLibros.Columns[5].Width = 50;
        }
        private void LlenarDgv()
        {
            DGV_ListaLibros.Rows.Clear();
            DataSet ds = new DataSet();
            ds = DatosObjLibros.listadoLibros("todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DGV_ListaLibros.Rows.Add(dr[0].ToString(), dr[1], dr[2].ToString());
                }
            }
            else
                MessageBox.Show("No hay Libros cargados");
        }
        void LlenarCombos()
        { //llena un combo desde una lista con descripcion y código

            cb_NomApeAut.DataSource = DatosObjLibros.ObtenerAutor(); // se define el origen con la Lista
            cb_NomApeAut.DisplayMember = "p_NombreApellido";
            cb_NomApeAut.ValueMember = "P_IDAutor";

            cb_EDITORIAL.DataSource = DatosObjLibros.ObtenerEditorial(); // se define el origen con la Lista
            cb_EDITORIAL.DisplayMember = "P_Nombre";
            cb_EDITORIAL.ValueMember = "P_IdEditorial";

            cb_GENERO.DataSource = DatosObjLibros.ObtenerGenero(); // se define el origen con la Lista
            cb_GENERO.DisplayMember = "P_NombreGenero";
            cb_GENERO.ValueMember = "P_IDGenero";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Libros NuevoLibro;
            NuevoLibro = new Libros(textBox_TITULO.Text, textBox_UBICACION.Text, Convert.ToInt32(cb_NomApeAut.SelectedValue), Convert.ToInt32(cb_EDITORIAL.SelectedValue), Convert.ToInt32(cb_GENERO.SelectedValue), checkBox1.Checked);

            Autor NuevoAutor;
            NuevoAutor = new Autor (cb_NomApeAut.Text);

            Editorial NuevaEditorial;
            NuevaEditorial = new Editorial(cb_EDITORIAL.Text);

            Genero NuevoGenero;
            NuevoGenero = new Genero(cb_GENERO.Text);

            int nGrabados = -1;
            nGrabados = DatosObjLibros.AbmLibros("Alta", NuevoLibro);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el libro en el sistema");
            }
            else
            {
                MessageBox.Show("Los libros se guardaron correctamente");
            }


        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_ALTA_AUTOR_Click(object sender, EventArgs e)
        {
            //this.Close();
            //llamar al form autor
            formAutor frmAut = new formAutor();
            frmAut.Show();

        }

        private void boton_ALTA_EDITORIAL_Click(object sender, EventArgs e)
        {
            formEditorial frmEdit = new formEditorial();
            frmEdit.Show();
            //cb_EDITORIAL.DataSource = DatosObjLibros.ObtenerEditorial(); // se define el origen con la Lista
            //cb_EDITORIAL.DisplayMember = "P_Nombre";
            //cb_EDITORIAL.ValueMember = "P_IdEditorial";
        }

        private void boton_ALTA_GENERO_Click(object sender, EventArgs e)
        {
            //this.Close();
            formGenero frmGen = new formGenero();
            frmGen.Show();
        }

        private void Eliminar_Lib_Click(object sender, EventArgs e)
        {
            LibrosExistente = new Libros(int.Parse(DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[0].Value.ToString()), textBox_TITULO.Text, textBox_UBICACION.Text, cb_NomApeAut.SelectedIndex, cb_EDITORIAL.SelectedIndex, cb_GENERO.SelectedIndex, checkBox1.Checked);

            int nResultado = -1;
            nResultado = DatosObjLibros.AbmLibros("Baja", LibrosExistente);
            if (nResultado != -1)
            {
                LlenarDgv();
            }
            else
            {
                MessageBox.Show("se produjo un error al eliminar el Libro");
            }
        }

        private void Modificar_Lib_Click(object sender, EventArgs e)
        {
            LibrosExistente = new Libros(int.Parse(DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[0].Value.ToString()), textBox_TITULO.Text, textBox_UBICACION.Text, cb_NomApeAut.SelectedIndex, cb_EDITORIAL.SelectedIndex, cb_GENERO.SelectedIndex, checkBox1.Checked);

            int nResultado = -1;
            nResultado = DatosObjLibros.AbmLibros("Modificar", LibrosExistente);
            if (nResultado != -1)
            {
                LlenarDgv();
            }
            else
            {
                MessageBox.Show("se produjo un error al modificar el Libro");
            }
        }

        private void Seleccionar_Lib_Click(object sender, EventArgs e)
        {
            textBox_TITULO.Text = DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[0].Value.ToString();
            textBox_UBICACION.Text = DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[1].Value.ToString();
            cb_NomApeAut.Text = DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[2].Value.ToString();
            cb_EDITORIAL.Text = DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[3].Value.ToString();
            cb_GENERO.Text = DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[4].Value.ToString();
            checkBox1.Text = DGV_ListaLibros.Rows[DGV_ListaLibros.CurrentRow.Index].Cells[5].Value.ToString();
        }
    }
}
