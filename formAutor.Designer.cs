
namespace Entidades
{
    partial class formAutor
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBNomApeAut = new System.Windows.Forms.TextBox();
            this.Btn_AgregarAut = new System.Windows.Forms.Button();
            this.Btn_SalirAut = new System.Windows.Forms.Button();
            this.DGVAut = new System.Windows.Forms.DataGridView();
            this.Btn_ModificarAut = new System.Windows.Forms.Button();
            this.Btn_EliminarAut = new System.Windows.Forms.Button();
            this.button1_volver_alta_libro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre y Apellido";
            // 
            // TxtBNomApeAut
            // 
            this.TxtBNomApeAut.Location = new System.Drawing.Point(161, 120);
            this.TxtBNomApeAut.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBNomApeAut.Name = "TxtBNomApeAut";
            this.TxtBNomApeAut.Size = new System.Drawing.Size(117, 20);
            this.TxtBNomApeAut.TabIndex = 4;
            // 
            // Btn_AgregarAut
            // 
            this.Btn_AgregarAut.Location = new System.Drawing.Point(61, 162);
            this.Btn_AgregarAut.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_AgregarAut.Name = "Btn_AgregarAut";
            this.Btn_AgregarAut.Size = new System.Drawing.Size(52, 26);
            this.Btn_AgregarAut.TabIndex = 7;
            this.Btn_AgregarAut.Text = "Agregar";
            this.Btn_AgregarAut.UseVisualStyleBackColor = true;
            this.Btn_AgregarAut.Click += new System.EventHandler(this.Btn_AgregarAut_Click);
            // 
            // Btn_SalirAut
            // 
            this.Btn_SalirAut.Location = new System.Drawing.Point(149, 162);
            this.Btn_SalirAut.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SalirAut.Name = "Btn_SalirAut";
            this.Btn_SalirAut.Size = new System.Drawing.Size(50, 26);
            this.Btn_SalirAut.TabIndex = 8;
            this.Btn_SalirAut.Text = "Salir";
            this.Btn_SalirAut.UseVisualStyleBackColor = true;
            this.Btn_SalirAut.Click += new System.EventHandler(this.Btn_SalirAut_Click);
            // 
            // DGVAut
            // 
            this.DGVAut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAut.Location = new System.Drawing.Point(299, 23);
            this.DGVAut.Margin = new System.Windows.Forms.Padding(2);
            this.DGVAut.Name = "DGVAut";
            this.DGVAut.RowHeadersWidth = 62;
            this.DGVAut.RowTemplate.Height = 28;
            this.DGVAut.Size = new System.Drawing.Size(395, 177);
            this.DGVAut.TabIndex = 9;
            this.DGVAut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAut_CellClick);
            // 
            // Btn_ModificarAut
            // 
            this.Btn_ModificarAut.Location = new System.Drawing.Point(399, 216);
            this.Btn_ModificarAut.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ModificarAut.Name = "Btn_ModificarAut";
            this.Btn_ModificarAut.Size = new System.Drawing.Size(67, 32);
            this.Btn_ModificarAut.TabIndex = 11;
            this.Btn_ModificarAut.Text = "Modificar";
            this.Btn_ModificarAut.UseVisualStyleBackColor = true;
            this.Btn_ModificarAut.Click += new System.EventHandler(this.Btn_ModificarAut_Click);
            // 
            // Btn_EliminarAut
            // 
            this.Btn_EliminarAut.Location = new System.Drawing.Point(535, 216);
            this.Btn_EliminarAut.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_EliminarAut.Name = "Btn_EliminarAut";
            this.Btn_EliminarAut.Size = new System.Drawing.Size(67, 32);
            this.Btn_EliminarAut.TabIndex = 12;
            this.Btn_EliminarAut.Text = "Eliminar";
            this.Btn_EliminarAut.UseVisualStyleBackColor = true;
            this.Btn_EliminarAut.Click += new System.EventHandler(this.Btn_EliminarAut_Click);
            // 
            // button1_volver_alta_libro
            // 
            this.button1_volver_alta_libro.Location = new System.Drawing.Point(87, 212);
            this.button1_volver_alta_libro.Name = "button1_volver_alta_libro";
            this.button1_volver_alta_libro.Size = new System.Drawing.Size(75, 41);
            this.button1_volver_alta_libro.TabIndex = 13;
            this.button1_volver_alta_libro.Text = "Ir a Alta Libro";
            this.button1_volver_alta_libro.UseVisualStyleBackColor = true;
            this.button1_volver_alta_libro.Click += new System.EventHandler(this.button1_volver_alta_libro_Click);
            // 
            // formAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(702, 258);
            this.Controls.Add(this.button1_volver_alta_libro);
            this.Controls.Add(this.Btn_EliminarAut);
            this.Controls.Add(this.Btn_ModificarAut);
            this.Controls.Add(this.DGVAut);
            this.Controls.Add(this.Btn_SalirAut);
            this.Controls.Add(this.Btn_AgregarAut);
            this.Controls.Add(this.TxtBNomApeAut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formAutor";
            this.Text = "Autor";
            ((System.ComponentModel.ISupportInitialize)(this.DGVAut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBNomApeAut;
        private System.Windows.Forms.Button Btn_AgregarAut;
        private System.Windows.Forms.Button Btn_SalirAut;
        private System.Windows.Forms.DataGridView DGVAut;
        private System.Windows.Forms.Button Btn_ModificarAut;
        private System.Windows.Forms.Button Btn_EliminarAut;
        private System.Windows.Forms.Button button1_volver_alta_libro;
    }
}