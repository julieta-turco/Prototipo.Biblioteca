
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Seleccionar_Lib = new System.Windows.Forms.Button();
            this.DGV_ListaLibros = new System.Windows.Forms.DataGridView();
            this.Eliminar_Lib = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Modificar_Lib = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ubicacion";
            // 
            // textBox_TITULO
            // 
            this.textBox_TITULO.Location = new System.Drawing.Point(118, 86);
            this.textBox_TITULO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_TITULO.Name = "textBox_TITULO";
            this.textBox_TITULO.Size = new System.Drawing.Size(205, 20);
            this.textBox_TITULO.TabIndex = 6;
            // 
            // textBox_UBICACION
            // 
            this.textBox_UBICACION.Location = new System.Drawing.Point(118, 118);
            this.textBox_UBICACION.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_UBICACION.Name = "textBox_UBICACION";
            this.textBox_UBICACION.Size = new System.Drawing.Size(205, 20);
            this.textBox_UBICACION.TabIndex = 9;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.White;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Location = new System.Drawing.Point(106, 322);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(67, 65);
            this.btnAGREGAR.TabIndex = 10;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.White;
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIR.Location = new System.Drawing.Point(194, 322);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(67, 65);
            this.btnSALIR.TabIndex = 11;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = false;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 52);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alta Libros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Genero";
            // 
            // cb_GENERO
            // 
            this.cb_GENERO.FormattingEnabled = true;
            this.cb_GENERO.Location = new System.Drawing.Point(118, 217);
            this.cb_GENERO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_GENERO.Name = "cb_GENERO";
            this.cb_GENERO.Size = new System.Drawing.Size(205, 21);
            this.cb_GENERO.TabIndex = 21;
            // 
            // cb_NomApeAut
            // 
            this.cb_NomApeAut.FormattingEnabled = true;
            this.cb_NomApeAut.Location = new System.Drawing.Point(118, 151);
            this.cb_NomApeAut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_NomApeAut.Name = "cb_NomApeAut";
            this.cb_NomApeAut.Size = new System.Drawing.Size(205, 21);
            this.cb_NomApeAut.TabIndex = 22;
            this.cb_NomApeAut.SelectedIndexChanged += new System.EventHandler(this.cb_NomApeAut_SelectedIndexChanged);
            // 
            // cb_EDITORIAL
            // 
            this.cb_EDITORIAL.FormattingEnabled = true;
            this.cb_EDITORIAL.Location = new System.Drawing.Point(118, 183);
            this.cb_EDITORIAL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_EDITORIAL.Name = "cb_EDITORIAL";
            this.cb_EDITORIAL.Size = new System.Drawing.Size(205, 21);
            this.cb_EDITORIAL.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(127, 261);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Si";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Seleccionar_Lib
            // 
            this.Seleccionar_Lib.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Seleccionar_Lib.Location = new System.Drawing.Point(495, 365);
            this.Seleccionar_Lib.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Seleccionar_Lib.Name = "Seleccionar_Lib";
            this.Seleccionar_Lib.Size = new System.Drawing.Size(98, 39);
            this.Seleccionar_Lib.TabIndex = 32;
            this.Seleccionar_Lib.Text = "Seleccionar";
            this.Seleccionar_Lib.UseVisualStyleBackColor = false;
            this.Seleccionar_Lib.Click += new System.EventHandler(this.Seleccionar_Lib_Click_1);
            // 
            // DGV_ListaLibros
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Beige;
            this.DGV_ListaLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_ListaLibros.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV_ListaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListaLibros.Location = new System.Drawing.Point(450, 70);
            this.DGV_ListaLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_ListaLibros.Name = "DGV_ListaLibros";
            this.DGV_ListaLibros.RowHeadersWidth = 62;
            this.DGV_ListaLibros.RowTemplate.Height = 28;
            this.DGV_ListaLibros.Size = new System.Drawing.Size(539, 291);
            this.DGV_ListaLibros.TabIndex = 31;
            // 
            // Eliminar_Lib
            // 
            this.Eliminar_Lib.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Eliminar_Lib.Location = new System.Drawing.Point(808, 365);
            this.Eliminar_Lib.Name = "Eliminar_Lib";
            this.Eliminar_Lib.Size = new System.Drawing.Size(98, 39);
            this.Eliminar_Lib.TabIndex = 30;
            this.Eliminar_Lib.Text = "Eliminar";
            this.Eliminar_Lib.UseVisualStyleBackColor = false;
            this.Eliminar_Lib.Click += new System.EventHandler(this.Eliminar_Lib_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 52);
            this.label8.TabIndex = 28;
            this.label8.Text = "Lista Libros";
            // 
            // Modificar_Lib
            // 
            this.Modificar_Lib.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Modificar_Lib.Location = new System.Drawing.Point(655, 365);
            this.Modificar_Lib.Name = "Modificar_Lib";
            this.Modificar_Lib.Size = new System.Drawing.Size(98, 39);
            this.Modificar_Lib.TabIndex = 29;
            this.Modificar_Lib.Text = "Modificar";
            this.Modificar_Lib.UseVisualStyleBackColor = false;
            this.Modificar_Lib.Click += new System.EventHandler(this.Modificar_Lib_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(333, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Location = new System.Drawing.Point(333, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Location = new System.Drawing.Point(333, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // formLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1003, 430);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Seleccionar_Lib);
            this.Controls.Add(this.DGV_ListaLibros);
            this.Controls.Add(this.Eliminar_Lib);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Modificar_Lib);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button Seleccionar_Lib;
        private System.Windows.Forms.DataGridView DGV_ListaLibros;
        private System.Windows.Forms.Button Eliminar_Lib;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Modificar_Lib;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}