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
                    DGVAut.Rows.Add(dr[0].ToString(), dr[1]);
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
            string nombreAut = TxtBNomApeAut.Text;

            if (nombreAut == "")
            {
                MessageBox.Show("No debe dejar el campo vacío. Por favor completelo antes de continuar");
            }
            else
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
                    MessageBox.Show("Autor agregado con exito");

                }
            }
        }

        private void Btn_SalirAut_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void BtnSelecAut_Click(object sender, EventArgs e)
        {
           
        }//se reemplazo por el evento cellclick

        private void Btn_ModificarAut_Click(object sender, EventArgs e)
        {
            string nombreAut = TxtBNomApeAut.Text;

            if (nombreAut == "")
            {
                MessageBox.Show("No debe dejar el campo vacío. Por favor completelo antes de continuar");
            }
            else
            {
                AutorExistente = new Autor(int.Parse(DGVAut.Rows[DGVAut.CurrentRow.Index].Cells[0].Value.ToString()), TxtBNomApeAut.Text);


                int nResultado = -1;
                nResultado = DatosObjAutor.AbmAutor("Modificar", AutorExistente);
                if (nResultado != -1)
                {
                    LlenarDgv();
                    MessageBox.Show("Autor modificado con exito");
                }
                else
                {
                    MessageBox.Show("se produjo un error al modificar el autor");
                }
            }
        }

        private void Btn_EliminarAut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro que desea eliminar?");
            AutorExistente = new Autor(int.Parse(DGVAut.Rows[DGVAut.CurrentRow.Index].Cells[0].Value.ToString()), TxtBNomApeAut.Text);


            int nResultado = -1;
            nResultado = DatosObjAutor.AbmAutor("Baja", AutorExistente);
            if (nResultado != -1)
            {
                LlenarDgv();
                MessageBox.Show("Autor eliminado con exito");
            }
            else
            {
                MessageBox.Show("se produjo un error al modificar el autor");
            }
        }

        private void DGVAut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtBNomApeAut.Text = DGVAut.Rows[DGVAut.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void button1_volver_alta_libro_Click(object sender, EventArgs e)
        {
            this.Close();
            formLibros frmLib = new formLibros();
            frmLib.Show();
        }
    }
}
