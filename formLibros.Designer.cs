
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TITULO = new System.Windows.Forms.TextBox();
            this.textBox_UBICACION = new System.Windows.Forms.TextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_GENERO = new System.Windows.Forms.ComboBox();
            this.cb_NomApeAut = new System.Windows.Forms.ComboBox();
            this.cb_EDITORIAL = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DGV_ListaLibros = new System.Windows.Forms.DataGridView();
            this.Eliminar_Lib = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Modificar_Lib = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaLibros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ubicacion";
            // 
            // textBox_TITULO
            // 
            this.textBox_TITULO.Location = new System.Drawing.Point(162, 88);
            this.textBox_TITULO.Name = "textBox_TITULO";
            this.textBox_TITULO.Size = new System.Drawing.Size(306, 35);
            this.textBox_TITULO.TabIndex = 22;
            this.textBox_TITULO.TextChanged += new System.EventHandler(this.textBox_TITULO_TextChanged);
            // 
            // textBox_UBICACION
            // 
            this.textBox_UBICACION.Location = new System.Drawing.Point(162, 138);
            this.textBox_UBICACION.Name = "textBox_UBICACION";
            this.textBox_UBICACION.Size = new System.Drawing.Size(306, 35);
            this.textBox_UBICACION.TabIndex = 9;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.White;
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Location = new System.Drawing.Point(84, 548);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(100, 100);
            this.btnAGREGAR.TabIndex = 11;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.White;
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIR.Location = new System.Drawing.Point(244, 548);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(100, 100);
            this.btnSALIR.TabIndex = 11;
            this.btnSALIR.Text = "Limpiar";
            this.btnSALIR.UseVisualStyleBackColor = false;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Autor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Genero";
            // 
            // cb_GENERO
            // 
            this.cb_GENERO.FormattingEnabled = true;
            this.cb_GENERO.Location = new System.Drawing.Point(162, 289);
            this.cb_GENERO.Name = "cb_GENERO";
            this.cb_GENERO.Size = new System.Drawing.Size(306, 37);
            this.cb_GENERO.TabIndex = 24;
            // 
            // cb_NomApeAut
            // 
            this.cb_NomApeAut.FormattingEnabled = true;
            this.cb_NomApeAut.Location = new System.Drawing.Point(162, 188);
            this.cb_NomApeAut.Name = "cb_NomApeAut";
            this.cb_NomApeAut.Size = new System.Drawing.Size(306, 37);
            this.cb_NomApeAut.TabIndex = 23;
            this.cb_NomApeAut.SelectedIndexChanged += new System.EventHandler(this.cb_NomApeAut_SelectedIndexChanged);
            // 
            // cb_EDITORIAL
            // 
            this.cb_EDITORIAL.FormattingEnabled = true;
            this.cb_EDITORIAL.Location = new System.Drawing.Point(162, 238);
            this.cb_EDITORIAL.Name = "cb_EDITORIAL";
            this.cb_EDITORIAL.Size = new System.Drawing.Size(306, 37);
            this.cb_EDITORIAL.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkBox1.Location = new System.Drawing.Point(178, 365);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 33);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Si";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DGV_ListaLibros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.DGV_ListaLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_ListaLibros.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV_ListaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListaLibros.Location = new System.Drawing.Point(608, 108);
            this.DGV_ListaLibros.Name = "DGV_ListaLibros";
            this.DGV_ListaLibros.RowHeadersWidth = 62;
            this.DGV_ListaLibros.RowTemplate.Height = 28;
            this.DGV_ListaLibros.Size = new System.Drawing.Size(808, 448);
            this.DGV_ListaLibros.TabIndex = 31;
            this.DGV_ListaLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ListaLibros_CellClick);
            // 
            // Eliminar_Lib
            // 
            this.Eliminar_Lib.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Eliminar_Lib.Location = new System.Drawing.Point(1113, 588);
            this.Eliminar_Lib.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Eliminar_Lib.Name = "Eliminar_Lib";
            this.Eliminar_Lib.Size = new System.Drawing.Size(147, 60);
            this.Eliminar_Lib.TabIndex = 30;
            this.Eliminar_Lib.Text = "Eliminar";
            this.Eliminar_Lib.UseVisualStyleBackColor = false;
            this.Eliminar_Lib.Click += new System.EventHandler(this.Eliminar_Lib_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(616, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(369, 75);
            this.label8.TabIndex = 28;
            this.label8.Text = "Lista Libros";
            // 
            // Modificar_Lib
            // 
            this.Modificar_Lib.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Modificar_Lib.Location = new System.Drawing.Point(838, 588);
            this.Modificar_Lib.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Modificar_Lib.Name = "Modificar_Lib";
            this.Modificar_Lib.Size = new System.Drawing.Size(147, 60);
            this.Modificar_Lib.TabIndex = 29;
            this.Modificar_Lib.Text = "Modificar";
            this.Modificar_Lib.UseVisualStyleBackColor = false;
            this.Modificar_Lib.Click += new System.EventHandler(this.Modificar_Lib_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(484, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 33;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Location = new System.Drawing.Point(484, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 34;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Location = new System.Drawing.Point(484, 289);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 43);
            this.button3.TabIndex = 35;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cb_EDITORIAL);
            this.groupBox1.Controls.Add(this.cb_NomApeAut);
            this.groupBox1.Controls.Add(this.cb_GENERO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_UBICACION);
            this.groupBox1.Controls.Add(this.textBox_TITULO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 434);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Alta Libro";
            // 
            // button_salir
            // 
            this.button_salir.BackColor = System.Drawing.Color.White;
            this.button_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salir.Location = new System.Drawing.Point(423, 548);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(100, 100);
            this.button_salir.TabIndex = 37;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = false;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // formLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1438, 749);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_ListaLibros);
            this.Controls.Add(this.Eliminar_Lib);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Modificar_Lib);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnAGREGAR);
            this.Name = "formLibros";
            this.Text = "formLibros";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListaLibros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_GENERO;
        private System.Windows.Forms.ComboBox cb_NomApeAut;
        private System.Windows.Forms.ComboBox cb_EDITORIAL;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView DGV_ListaLibros;
        private System.Windows.Forms.Button Eliminar_Lib;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Modificar_Lib;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_salir;
    }
}