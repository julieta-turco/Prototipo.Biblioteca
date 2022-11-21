
namespace Entidades
{
    partial class BuscarLibros
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
            this.DGVBuscarLib = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUbicacion = new System.Windows.Forms.RadioButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbTitulo = new System.Windows.Forms.RadioButton();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscarLib)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVBuscarLib
            // 
            this.DGVBuscarLib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBuscarLib.Location = new System.Drawing.Point(393, 51);
            this.DGVBuscarLib.Name = "DGVBuscarLib";
            this.DGVBuscarLib.RowHeadersWidth = 62;
            this.DGVBuscarLib.RowTemplate.Height = 28;
            this.DGVBuscarLib.Size = new System.Drawing.Size(748, 283);
            this.DGVBuscarLib.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUbicacion);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.rbTitulo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar busqueda por:";
            // 
            // rbUbicacion
            // 
            this.rbUbicacion.AutoSize = true;
            this.rbUbicacion.Location = new System.Drawing.Point(16, 89);
            this.rbUbicacion.Name = "rbUbicacion";
            this.rbUbicacion.Size = new System.Drawing.Size(145, 33);
            this.rbUbicacion.TabIndex = 6;
            this.rbUbicacion.TabStop = true;
            this.rbUbicacion.Text = "Ubicacion";
            this.rbUbicacion.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(16, 134);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(204, 35);
            this.txtBusqueda.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(39, 214);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 37);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(192, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbTitulo
            // 
            this.rbTitulo.AutoSize = true;
            this.rbTitulo.Location = new System.Drawing.Point(16, 49);
            this.rbTitulo.Name = "rbTitulo";
            this.rbTitulo.Size = new System.Drawing.Size(99, 33);
            this.rbTitulo.TabIndex = 5;
            this.rbTitulo.TabStop = true;
            this.rbTitulo.Text = "Titulo";
            this.rbTitulo.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1017, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 35);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // BuscarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1176, 380);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVBuscarLib);
            this.Name = "BuscarLibros";
            this.Text = "BuscarLibros";
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscarLib)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVBuscarLib;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTitulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbUbicacion;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnVolver;
    }
}