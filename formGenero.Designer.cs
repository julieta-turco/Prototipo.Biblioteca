
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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Genero)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 63);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nuevo Genero Literario";
            // 
            // Btn_IngresarGen
            // 
            this.Btn_IngresarGen.Location = new System.Drawing.Point(73, 201);
            this.Btn_IngresarGen.Name = "Btn_IngresarGen";
            this.Btn_IngresarGen.Size = new System.Drawing.Size(90, 40);
            this.Btn_IngresarGen.TabIndex = 7;
            this.Btn_IngresarGen.Text = "Ingresar";
            this.Btn_IngresarGen.UseVisualStyleBackColor = true;
            this.Btn_IngresarGen.Click += new System.EventHandler(this.Btn_IngresarGen_Click);
            // 
            // Btn_SalirGen
            // 
            this.Btn_SalirGen.Location = new System.Drawing.Point(231, 201);
            this.Btn_SalirGen.Name = "Btn_SalirGen";
            this.Btn_SalirGen.Size = new System.Drawing.Size(90, 40);
            this.Btn_SalirGen.TabIndex = 8;
            this.Btn_SalirGen.Text = "Salir";
            this.Btn_SalirGen.UseVisualStyleBackColor = true;
            this.Btn_SalirGen.Click += new System.EventHandler(this.Btn_SalirGen_Click);
            // 
            // TxtB_NomGenero
            // 
            this.TxtB_NomGenero.Location = new System.Drawing.Point(177, 142);
            this.TxtB_NomGenero.Name = "TxtB_NomGenero";
            this.TxtB_NomGenero.Size = new System.Drawing.Size(254, 26);
            this.TxtB_NomGenero.TabIndex = 9;
            // 
            // DGV_Genero
            // 
            this.DGV_Genero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Genero.Location = new System.Drawing.Point(480, 55);
            this.DGV_Genero.Name = "DGV_Genero";
            this.DGV_Genero.RowHeadersWidth = 62;
            this.DGV_Genero.RowTemplate.Height = 28;
            this.DGV_Genero.Size = new System.Drawing.Size(500, 150);
            this.DGV_Genero.TabIndex = 10;
            this.DGV_Genero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Genero_CellClick);
            // 
            // Btn_ModificarGen
            // 
            this.Btn_ModificarGen.Location = new System.Drawing.Point(599, 211);
            this.Btn_ModificarGen.Name = "Btn_ModificarGen";
            this.Btn_ModificarGen.Size = new System.Drawing.Size(100, 50);
            this.Btn_ModificarGen.TabIndex = 12;
            this.Btn_ModificarGen.Text = "Modificar";
            this.Btn_ModificarGen.UseVisualStyleBackColor = true;
            this.Btn_ModificarGen.Click += new System.EventHandler(this.Btn_ModificarGen_Click);
            // 
            // Btn_EliminarGen
            // 
            this.Btn_EliminarGen.Location = new System.Drawing.Point(773, 211);
            this.Btn_EliminarGen.Name = "Btn_EliminarGen";
            this.Btn_EliminarGen.Size = new System.Drawing.Size(100, 50);
            this.Btn_EliminarGen.TabIndex = 13;
            this.Btn_EliminarGen.Text = "Eliminar";
            this.Btn_EliminarGen.UseVisualStyleBackColor = true;
            this.Btn_EliminarGen.Click += new System.EventHandler(this.Btn_EliminarGen_Click);
            // 
            // formGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 314);
            this.Controls.Add(this.Btn_EliminarGen);
            this.Controls.Add(this.Btn_ModificarGen);
            this.Controls.Add(this.DGV_Genero);
            this.Controls.Add(this.TxtB_NomGenero);
            this.Controls.Add(this.Btn_SalirGen);
            this.Controls.Add(this.Btn_IngresarGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
    }
}