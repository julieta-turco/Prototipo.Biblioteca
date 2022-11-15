
namespace capaPresentacion
{
    partial class formLibros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TITULO = new System.Windows.Forms.TextBox();
            this.textBox_UBICACION = new System.Windows.Forms.TextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_GENERO = new System.Windows.Forms.ComboBox();
            this.cb_NomApeAut = new System.Windows.Forms.ComboBox();
            this.cb_EDITORIAL = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.boton_ALTA_AUTOR = new System.Windows.Forms.Button();
            this.boton_ALTA_EDITORIAL = new System.Windows.Forms.Button();
            this.boton_ALTA_GENERO = new System.Windows.Forms.Button();
            this.Seleccionar_Lib = new System.Windows.Forms.Button();
            this.DGV_ListaLibros = new System.Windows.Forms.DataGridView();
            this.Eliminar_Lib = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Modificar_Lib = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ubicacion";
            // 
            // textBox_TITULO
            // 
            this.textBox_TITULO.Location = new System.Drawing.Point(177, 133);
            this.textBox_TITULO.Name = "textBox_TITULO";
            this.textBox_TITULO.Size = new System.Drawing.Size(305, 26);
            this.textBox_TITULO.TabIndex = 6;
            // 
            // textBox_UBICACION
            // 
            this.textBox_UBICACION.Location = new System.Drawing.Point(177, 181);
            this.textBox_UBICACION.Name = "textBox_UBICACION";
            this.textBox_UBICACION.Size = new System.Drawing.Size(305, 26);
            this.textBox_UBICACION.TabIndex = 9;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.White;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Location = new System.Drawing.Point(159, 495);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(100, 100);
            this.btnAGREGAR.TabIndex = 10;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.White;
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIR.Location = new System.Drawing.Point(291, 495);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(100, 100);
            this.btnSALIR.TabIndex = 11;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = false;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 33F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 86);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alta Libros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Genero";
            // 
            // cb_GENERO
            // 
            this.cb_GENERO.FormattingEnabled = true;
            this.cb_GENERO.Location = new System.Drawing.Point(177, 334);
            this.cb_GENERO.Name = "cb_GENERO";
            this.cb_GENERO.Size = new System.Drawing.Size(305, 28);
            this.cb_GENERO.TabIndex = 21;
            // 
            // cb_NomApeAut
            // 
            this.cb_NomApeAut.FormattingEnabled = true;
            this.cb_NomApeAut.Location = new System.Drawing.Point(177, 232);
            this.cb_NomApeAut.Name = "cb_NomApeAut";
            this.cb_NomApeAut.Size = new System.Drawing.Size(305, 28);
            this.cb_NomApeAut.TabIndex = 22;
            // 
            // cb_EDITORIAL
            // 
            this.cb_EDITORIAL.FormattingEnabled = true;
            this.cb_EDITORIAL.Location = new System.Drawing.Point(177, 282);
            this.cb_EDITORIAL.Name = "cb_EDITORIAL";
            this.cb_EDITORIAL.Size = new System.Drawing.Size(305, 28);
            this.cb_EDITORIAL.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(190, 402);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 24);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Si";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // boton_ALTA_AUTOR
            // 
            this.boton_ALTA_AUTOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton_ALTA_AUTOR.Location = new System.Drawing.Point(515, 236);
            this.boton_ALTA_AUTOR.Name = "boton_ALTA_AUTOR";
            this.boton_ALTA_AUTOR.Size = new System.Drawing.Size(30, 30);
            this.boton_ALTA_AUTOR.TabIndex = 25;
            this.boton_ALTA_AUTOR.Text = "+";
            this.boton_ALTA_AUTOR.UseVisualStyleBackColor = false;
            // 
            // boton_ALTA_EDITORIAL
            // 
            this.boton_ALTA_EDITORIAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton_ALTA_EDITORIAL.Location = new System.Drawing.Point(515, 289);
            this.boton_ALTA_EDITORIAL.Name = "boton_ALTA_EDITORIAL";
            this.boton_ALTA_EDITORIAL.Size = new System.Drawing.Size(30, 30);
            this.boton_ALTA_EDITORIAL.TabIndex = 26;
            this.boton_ALTA_EDITORIAL.Text = "+";
            this.boton_ALTA_EDITORIAL.UseVisualStyleBackColor = false;
            // 
            // boton_ALTA_GENERO
            // 
            this.boton_ALTA_GENERO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton_ALTA_GENERO.Location = new System.Drawing.Point(515, 339);
            this.boton_ALTA_GENERO.Name = "boton_ALTA_GENERO";
            this.boton_ALTA_GENERO.Size = new System.Drawing.Size(30, 30);
            this.boton_ALTA_GENERO.TabIndex = 27;
            this.boton_ALTA_GENERO.Text = "+";
            this.boton_ALTA_GENERO.UseVisualStyleBackColor = false;
            // 
            // Seleccionar_Lib
            // 
            this.Seleccionar_Lib.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Seleccionar_Lib.Location = new System.Drawing.Point(743, 561);
            this.Seleccionar_Lib.Name = "Seleccionar_Lib";
            this.Seleccionar_Lib.Size = new System.Drawing.Size(147, 60);
            this.Seleccionar_Lib.TabIndex = 32;
            this.Seleccionar_Lib.Text = "Seleccionar";
            this.Seleccionar_Lib.UseVisualStyleBackColor = false;
            // 
            // DGV_ListaLibros
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            this.DGV_ListaLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_ListaLibros.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV_ListaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListaLibros.Location = new System.Drawing.Point(675, 107);
            this.DGV_ListaLibros.Name = "DGV_ListaLibros";
            this.DGV_ListaLibros.RowHeadersWidth = 62;
            this.DGV_ListaLibros.RowTemplate.Height = 28;
            this.DGV_ListaLibros.Size = new System.Drawing.Size(808, 447);
            this.DGV_ListaLibros.TabIndex = 31;
            // 
            // Eliminar_Lib
            // 
            this.Eliminar_Lib.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Eliminar_Lib.Location = new System.Drawing.Point(1212, 561);
            this.Eliminar_Lib.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminar_Lib.Name = "Eliminar_Lib";
            this.Eliminar_Lib.Size = new System.Drawing.Size(147, 60);
            this.Eliminar_Lib.TabIndex = 30;
            this.Eliminar_Lib.Text = "Eliminar";
            this.Eliminar_Lib.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 33F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(660, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 86);
            this.label8.TabIndex = 28;
            this.label8.Text = "Lista Libros";
            // 
            // Modificar_Lib
            // 
            this.Modificar_Lib.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Modificar_Lib.Location = new System.Drawing.Point(982, 561);
            this.Modificar_Lib.Margin = new System.Windows.Forms.Padding(4);
            this.Modificar_Lib.Name = "Modificar_Lib";
            this.Modificar_Lib.Size = new System.Drawing.Size(147, 60);
            this.Modificar_Lib.TabIndex = 29;
            this.Modificar_Lib.Text = "Modificar";
            this.Modificar_Lib.UseVisualStyleBackColor = false;
            // 
            // formLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1505, 661);
            this.Controls.Add(this.Seleccionar_Lib);
            this.Controls.Add(this.DGV_ListaLibros);
            this.Controls.Add(this.Eliminar_Lib);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Modificar_Lib);
            this.Controls.Add(this.boton_ALTA_GENERO);
            this.Controls.Add(this.boton_ALTA_EDITORIAL);
            this.Controls.Add(this.boton_ALTA_AUTOR);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cb_EDITORIAL);
            this.Controls.Add(this.cb_NomApeAut);
            this.Controls.Add(this.cb_GENERO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.textBox_UBICACION);
            this.Controls.Add(this.textBox_TITULO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "formLibros";
            this.Text = "formLibros";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TITULO;
        private System.Windows.Forms.TextBox textBox_UBICACION;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_GENERO;
        private System.Windows.Forms.ComboBox cb_NomApeAut;
        private System.Windows.Forms.ComboBox cb_EDITORIAL;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button boton_ALTA_AUTOR;
        private System.Windows.Forms.Button boton_ALTA_EDITORIAL;
        private System.Windows.Forms.Button boton_ALTA_GENERO;
        private System.Windows.Forms.Button Seleccionar_Lib;
        private System.Windows.Forms.DataGridView DGV_ListaLibros;
        private System.Windows.Forms.Button Eliminar_Lib;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Modificar_Lib;
    }
}