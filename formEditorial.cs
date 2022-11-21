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
using capaDatos;
using capa_Entidades;

namespace capaPresentacion
{
    public partial class formEditorial : Form
    {
        Editorial AltaEditorial;
        Editorial EditorialExistente;
        NegLibros DatosObjEditorial = new NegLibros();
        public formEditorial()
        {
            InitializeComponent();
            CrearDgv();
            LlenarDgv();
        }

        public void LlenarDgv()
        {
            DGVEdit.Rows.Clear();
            DataSet ds = new DataSet();
            ds = DatosObjEditorial.listadoEditoriales("todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DGVEdit.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4]);
                }
            }
            else
            {
                MessageBox.Show("No hay editoriales cargadas en el sistema");
            }
        }

        public void CrearDgv()
        {
            DGVEdit.Columns.Add("0", "Id_Editorial");
            DGVEdit.Columns.Add("1", "Nombre");
            DGVEdit.Columns.Add("2", "Direccion");
            DGVEdit.Columns.Add("3", "Telefono");
            DGVEdit.Columns.Add("4", "Email");
        }

        private void Btn_AgregarEdit_Click(object sender, EventArgs e)
        {
            string nombreEdit = TxtBNombreEdit.Text;
            string direccion = TxtBDireEdit.Text;
            string telefono = TxtBNumEdit.Text;
            string mail = TxtBMailEdit.Text;


            if ((nombreEdit == "") || (direccion == "") || (telefono == "") || (mail == ""))
            {
                MessageBox.Show("No debe dejar campos vacíos. Por favor completelos antes de continuar");
                
            }
            else
            {

                int nGrabados = -1;
                AltaEditorial = new Editorial(TxtBNombreEdit.Text, TxtBDireEdit.Text, int.Parse(TxtBNumEdit.Text), TxtBMailEdit.Text);

                nGrabados = DatosObjEditorial.AbmEditorial("Alta", AltaEditorial);

                if (nGrabados == -1)
                {
                    MessageBox.Show("No se pudo grabar la editorial en el sistema");
                }
                else
                {
                    LlenarDgv();
                    MessageBox.Show("Editorial agregada con exito");
                }
            }
        }

        private void Btn_SalirEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSelecEdit_Click(object sender, EventArgs e)//se reemplazo con el evento cellclilck
        {

        }

        private void BtnModificarEdit_Click(object sender, EventArgs e)
        {
            string nombreEdit = TxtBNombreEdit.Text;
            string direccion = TxtBDireEdit.Text;
            string telefono = TxtBNumEdit.Text;
            string mail = TxtBMailEdit.Text;


            if ((nombreEdit == "") || (direccion == "") || (telefono == "") || (mail == ""))
            {
                MessageBox.Show("No debe dejar campos vacíos. Por favor completelos antes de continuar");
            }
            else
            {            
                EditorialExistente = new Editorial(int.Parse(DGVEdit.Rows[DGVEdit.CurrentRow.Index].Cells[0].Value.ToString()), TxtBNombreEdit.Text, TxtBDireEdit.Text, int.Parse(TxtBNumEdit.Text), TxtBMailEdit.Text);
                int nResultado = -1;
                nResultado = DatosObjEditorial.AbmEditorial("Modificar", EditorialExistente);
               if (nResultado != -1)
               {
                LlenarDgv();
                MessageBox.Show("Editorial modificada con exito");
               }
                else
                    {
                      MessageBox.Show("se produjo un error al modificar la Editorial");
                     }
            }
    }

        private void BtnEliminarEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro que desea eliminar?");
            EditorialExistente = new Editorial(int.Parse(DGVEdit.Rows[DGVEdit.CurrentRow.Index].Cells[0].Value.ToString()), TxtBNombreEdit.Text, TxtBDireEdit.Text, int.Parse(TxtBNumEdit.Text), TxtBMailEdit.Text);

            int nResultado = -1;
            nResultado = DatosObjEditorial.AbmEditorial("Baja", EditorialExistente);
            if (nResultado != -1)
            {
                LlenarDgv();
                MessageBox.Show("Editorial eliminada con exito");
            }
            else
            {
                MessageBox.Show("se produjo un error al eliminar la Editorial");
            }
        }

        private void DGVEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtBNombreEdit.Text = DGVEdit.Rows[DGVEdit.CurrentRow.Index].Cells[1].Value.ToString();
            TxtBDireEdit.Text = DGVEdit.Rows[DGVEdit.CurrentRow.Index].Cells[2].Value.ToString();
            TxtBNumEdit.Text = DGVEdit.Rows[DGVEdit.CurrentRow.Index].Cells[3].Value.ToString();
            TxtBMailEdit.Text = DGVEdit.Rows[DGVEdit.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void button1_volver_alta_Click(object sender, EventArgs e)
        {
            this.Close();
            formLibros frmLib = new formLibros();
            frmLib.Show();
        }

        private void TxtBNumEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <=255) )
            {
                MessageBox.Show("Solo puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
