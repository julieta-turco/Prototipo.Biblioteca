
namespace capaPresentacion
{
    partial class formEditorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NomEdit = new System.Windows.Forms.Label();
            this.DireEdit = new System.Windows.Forms.Label();
            this.NumEdit = new System.Windows.Forms.Label();
            this.MailEdit = new System.Windows.Forms.Label();
            this.Btn_AgregarEdit = new System.Windows.Forms.Button();
            this.Btn_SalirEdit = new System.Windows.Forms.Button();
            this.DGVEdit = new System.Windows.Forms.DataGridView();
            this.BtnEliminarEdit = new System.Windows.Forms.Button();
            this.BtnModificarEdit = new System.Windows.Forms.Button();
            this.TxtBNumEdit = new System.Windows.Forms.TextBox();
            this.TxtBDireEdit = new System.Windows.Forms.TextBox();
            this.TxtBMailEdit = new System.Windows.Forms.TextBox();
            this.TxtBNombreEdit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Ingreso Editorial";
            // 
            // NomEdit
            // 
            this.NomEdit.AutoSize = true;
            this.NomEdit.Location = new System.Drawing.Point(28, 214);
            this.NomEdit.Name = "NomEdit";
            this.NomEdit.Size = new System.Drawing.Size(65, 20);
            this.NomEdit.TabIndex = 2;
            this.NomEdit.Text = "Nombre";
            // 
            // DireEdit
            // 
            this.DireEdit.AutoSize = true;
            this.DireEdit.Location = new System.Drawing.Point(28, 267);
            this.DireEdit.Name = "DireEdit";
            this.DireEdit.Size = new System.Drawing.Size(75, 20);
            this.DireEdit.TabIndex = 3;
            this.DireEdit.Text = "Direccion";
            // 
            // NumEdit
            // 
            this.NumEdit.AutoSize = true;
            this.NumEdit.Location = new System.Drawing.Point(28, 319);
            this.NumEdit.Name = "NumEdit";
            this.NumEdit.Size = new System.Drawing.Size(65, 20);
            this.NumEdit.TabIndex = 4;
            this.NumEdit.Text = "Numero";
            // 
            // MailEdit
            // 
            this.MailEdit.AutoSize = true;
            this.MailEdit.Location = new System.Drawing.Point(28, 371);
            this.MailEdit.Name = "MailEdit";
            this.MailEdit.Size = new System.Drawing.Size(37, 20);
            this.MailEdit.TabIndex = 5;
            this.MailEdit.Text = "Mail";
            // 
            // Btn_AgregarEdit
            // 
            this.Btn_AgregarEdit.Location = new System.Drawing.Point(87, 433);
            this.Btn_AgregarEdit.Name = "Btn_AgregarEdit";
            this.Btn_AgregarEdit.Size = new System.Drawing.Size(100, 50);
            this.Btn_AgregarEdit.TabIndex = 11;
            this.Btn_AgregarEdit.Text = "Agregar";
            this.Btn_AgregarEdit.UseVisualStyleBackColor = true;
            this.Btn_AgregarEdit.Click += new System.EventHandler(this.Btn_AgregarEdit_Click);
            // 
            // Btn_SalirEdit
            // 
            this.Btn_SalirEdit.Location = new System.Drawing.Point(292, 433);
            this.Btn_SalirEdit.Name = "Btn_SalirEdit";
            this.Btn_SalirEdit.Size = new System.Drawing.Size(100, 50);
            this.Btn_SalirEdit.TabIndex = 12;
            this.Btn_SalirEdit.Text = "Salir";
            this.Btn_SalirEdit.UseVisualStyleBackColor = true;
            this.Btn_SalirEdit.Click += new System.EventHandler(this.Btn_SalirEdit_Click);
            // 
            // DGVEdit
            // 
            this.DGVEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEdit.Location = new System.Drawing.Point(487, 127);
            this.DGVEdit.Name = "DGVEdit";
            this.DGVEdit.RowHeadersWidth = 62;
            this.DGVEdit.RowTemplate.Height = 28;
            this.DGVEdit.Size = new System.Drawing.Size(600, 300);
            this.DGVEdit.TabIndex = 13;
            this.DGVEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEdit_CellClick);
            // 
            // BtnEliminarEdit
            // 
            this.BtnEliminarEdit.Location = new System.Drawing.Point(862, 433);
            this.BtnEliminarEdit.Name = "BtnEliminarEdit";
            this.BtnEliminarEdit.Size = new System.Drawing.Size(100, 50);
            this.BtnEliminarEdit.TabIndex = 15;
            this.BtnEliminarEdit.Text = "Eliminar";
            this.BtnEliminarEdit.UseVisualStyleBackColor = true;
            this.BtnEliminarEdit.Click += new System.EventHandler(this.BtnEliminarEdit_Click);
            // 
            // BtnModificarEdit
            // 
            this.BtnModificarEdit.Location = new System.Drawing.Point(662, 433);
            this.BtnModificarEdit.Name = "BtnModificarEdit";
            this.BtnModificarEdit.Size = new System.Drawing.Size(100, 50);
            this.BtnModificarEdit.TabIndex = 16;
            this.BtnModificarEdit.Text = "Modificar";
            this.BtnModificarEdit.UseVisualStyleBackColor = true;
            this.BtnModificarEdit.Click += new System.EventHandler(this.BtnModificarEdit_Click);
            // 
            // TxtBNumEdit
            // 
            this.TxtBNumEdit.Location = new System.Drawing.Point(173, 313);
            this.TxtBNumEdit.Name = "TxtBNumEdit";
            this.TxtBNumEdit.Size = new System.Drawing.Size(219, 26);
            this.TxtBNumEdit.TabIndex = 7;
            // 
            // TxtBDireEdit
            // 
            this.TxtBDireEdit.Location = new System.Drawing.Point(173, 261);
            this.TxtBDireEdit.Name = "TxtBDireEdit";
            this.TxtBDireEdit.Size = new System.Drawing.Size(219, 26);
            this.TxtBDireEdit.TabIndex = 8;
            // 
            // TxtBMailEdit
            // 
            this.TxtBMailEdit.Location = new System.Drawing.Point(173, 365);
            this.TxtBMailEdit.Name = "TxtBMailEdit";
            this.TxtBMailEdit.Size = new System.Drawing.Size(219, 26);
            this.TxtBMailEdit.TabIndex = 9;
            // 
            // TxtBNombreEdit
            // 
            this.TxtBNombreEdit.Location = new System.Drawing.Point(173, 208);
            this.TxtBNombreEdit.Name = "TxtBNombreEdit";
            this.TxtBNombreEdit.Size = new System.Drawing.Size(219, 26);
            this.TxtBNombreEdit.TabIndex = 10;
            // 
            // formEditorial
            // 
            this.AcceptButton = this.Btn_AgregarEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 514);
            this.ControlBox = false;
            this.Controls.Add(this.BtnModificarEdit);
            this.Controls.Add(this.BtnEliminarEdit);
            this.Controls.Add(this.DGVEdit);
            this.Controls.Add(this.Btn_SalirEdit);
            this.Controls.Add(this.Btn_AgregarEdit);
            this.Controls.Add(this.TxtBNombreEdit);
            this.Controls.Add(this.TxtBMailEdit);
            this.Controls.Add(this.TxtBDireEdit);
            this.Controls.Add(this.TxtBNumEdit);
            this.Controls.Add(this.MailEdit);
            this.Controls.Add(this.NumEdit);
            this.Controls.Add(this.DireEdit);
            this.Controls.Add(this.NomEdit);
            this.Controls.Add(this.label1);
            this.Name = "formEditorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Editorial";
            ((System.ComponentModel.ISupportInitialize)(this.DGVEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NomEdit;
        private System.Windows.Forms.Label DireEdit;
        private System.Windows.Forms.Label NumEdit;
        private System.Windows.Forms.Label MailEdit;
        private System.Windows.Forms.Button Btn_AgregarEdit;
        private System.Windows.Forms.Button Btn_SalirEdit;
        private System.Windows.Forms.DataGridView DGVEdit;
        private System.Windows.Forms.Button BtnEliminarEdit;
        private System.Windows.Forms.Button BtnModificarEdit;
        private System.Windows.Forms.TextBox TxtBNumEdit;
        private System.Windows.Forms.TextBox TxtBDireEdit;
        private System.Windows.Forms.TextBox TxtBMailEdit;
        private System.Windows.Forms.TextBox TxtBNombreEdit;
    }
}