
namespace capaPresentacion
{
    partial class formGenero
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_IngresarGen = new System.Windows.Forms.Button();
            this.Btn_SalirGen = new System.Windows.Forms.Button();
            this.TxtB_NomGenero = new System.Windows.Forms.TextBox();
            this.DGV_Genero = new System.Windows.Forms.DataGridView();
            this.Btn_ModificarGen = new System.Windows.Forms.Button();
            this.Btn_EliminarGen = new System.Windows.Forms.Button();
            this.button1_volver_alt_libro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Genero)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nuevo Genero Literario";
            // 
            // Btn_IngresarGen
            // 
            this.Btn_IngresarGen.Location = new System.Drawing.Point(49, 131);
            this.Btn_IngresarGen.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_IngresarGen.Name = "Btn_IngresarGen";
            this.Btn_IngresarGen.Size = new System.Drawing.Size(60, 26);
            this.Btn_IngresarGen.TabIndex = 7;
            this.Btn_IngresarGen.Text = "Ingresar";
            this.Btn_IngresarGen.UseVisualStyleBackColor = true;
            this.Btn_IngresarGen.Click += new System.EventHandler(this.Btn_IngresarGen_Click);
            // 
            // Btn_SalirGen
            // 
            this.Btn_SalirGen.Location = new System.Drawing.Point(154, 131);
            this.Btn_SalirGen.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SalirGen.Name = "Btn_SalirGen";
            this.Btn_SalirGen.Size = new System.Drawing.Size(60, 26);
            this.Btn_SalirGen.TabIndex = 8;
            this.Btn_SalirGen.Text = "Salir";
            this.Btn_SalirGen.UseVisualStyleBackColor = true;
            this.Btn_SalirGen.Click += new System.EventHandler(this.Btn_SalirGen_Click);
            // 
            // TxtB_NomGenero
            // 
            this.TxtB_NomGenero.Location = new System.Drawing.Point(138, 94);
            this.TxtB_NomGenero.Margin = new System.Windows.Forms.Padding(2);
            this.TxtB_NomGenero.Name = "TxtB_NomGenero";
            this.TxtB_NomGenero.Size = new System.Drawing.Size(171, 20);
            this.TxtB_NomGenero.TabIndex = 9;
            // 
            // DGV_Genero
            // 
            this.DGV_Genero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Genero.Location = new System.Drawing.Point(329, 61);
            this.DGV_Genero.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Genero.Name = "DGV_Genero";
            this.DGV_Genero.RowHeadersWidth = 62;
            this.DGV_Genero.RowTemplate.Height = 28;
            this.DGV_Genero.Size = new System.Drawing.Size(333, 97);
            this.DGV_Genero.TabIndex = 10;
            this.DGV_Genero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Genero_CellClick);
            // 
            // Btn_ModificarGen
            // 
            this.Btn_ModificarGen.Location = new System.Drawing.Point(397, 176);
            this.Btn_ModificarGen.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ModificarGen.Name = "Btn_ModificarGen";
            this.Btn_ModificarGen.Size = new System.Drawing.Size(67, 32);
            this.Btn_ModificarGen.TabIndex = 12;
            this.Btn_ModificarGen.Text = "Modificar";
            this.Btn_ModificarGen.UseVisualStyleBackColor = true;
            this.Btn_ModificarGen.Click += new System.EventHandler(this.Btn_ModificarGen_Click);
            // 
            // Btn_EliminarGen
            // 
            this.Btn_EliminarGen.Location = new System.Drawing.Point(511, 176);
            this.Btn_EliminarGen.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_EliminarGen.Name = "Btn_EliminarGen";
            this.Btn_EliminarGen.Size = new System.Drawing.Size(67, 32);
            this.Btn_EliminarGen.TabIndex = 13;
            this.Btn_EliminarGen.Text = "Eliminar";
            this.Btn_EliminarGen.UseVisualStyleBackColor = true;
            this.Btn_EliminarGen.Click += new System.EventHandler(this.Btn_EliminarGen_Click);
            // 
            // button1_volver_alt_libro
            // 
            this.button1_volver_alt_libro.Location = new System.Drawing.Point(118, 191);
            this.button1_volver_alt_libro.Name = "button1_volver_alt_libro";
            this.button1_volver_alt_libro.Size = new System.Drawing.Size(75, 43);
            this.button1_volver_alt_libro.TabIndex = 14;
            this.button1_volver_alt_libro.Text = "Ir a Alta Libro";
            this.button1_volver_alt_libro.UseVisualStyleBackColor = true;
            this.button1_volver_alt_libro.Click += new System.EventHandler(this.button1_volver_alt_libro_Click);
            // 
            // formGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(673, 246);
            this.Controls.Add(this.button1_volver_alt_libro);
            this.Controls.Add(this.Btn_EliminarGen);
            this.Controls.Add(this.Btn_ModificarGen);
            this.Controls.Add(this.DGV_Genero);
            this.Controls.Add(this.TxtB_NomGenero);
            this.Controls.Add(this.Btn_SalirGen);
            this.Controls.Add(this.Btn_IngresarGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formGenero";
            this.Text = "genero";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Genero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_IngresarGen;
        private System.Windows.Forms.Button Btn_SalirGen;
        private System.Windows.Forms.TextBox TxtB_NomGenero;
        private System.Windows.Forms.DataGridView DGV_Genero;
        private System.Windows.Forms.Button Btn_ModificarGen;
        private System.Windows.Forms.Button Btn_EliminarGen;
        private System.Windows.Forms.Button button1_volver_alt_libro;
    }
}