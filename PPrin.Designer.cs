
namespace capaPresentacion
{
    partial class PPrin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.MenuStrip menuStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPrin));
            this.conexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip1.Font = new System.Drawing.Font("Yellowtail", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 9);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexionToolStripMenuItem,
            this.entidadesToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.salirToolStripMenuItem});
            menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            menuStrip1.Location = new System.Drawing.Point(6, 6);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            menuStrip1.Size = new System.Drawing.Size(364, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // conexionToolStripMenuItem
            // 
            this.conexionToolStripMenuItem.Name = "conexionToolStripMenuItem";
            this.conexionToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.conexionToolStripMenuItem.Text = "Conexion";
            this.conexionToolStripMenuItem.Click += new System.EventHandler(this.conexionToolStripMenuItem_Click);
            // 
            // entidadesToolStripMenuItem
            // 
            this.entidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.sociosToolStripMenuItem,
            this.generoToolStripMenuItem,
            this.editorialToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.entidadesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            this.entidadesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(50, 28);
            this.entidadesToolStripMenuItem.Text = "Alta";
            this.entidadesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(138, 28);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(138, 28);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // generoToolStripMenuItem
            // 
            this.generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            this.generoToolStripMenuItem.Size = new System.Drawing.Size(138, 28);
            this.generoToolStripMenuItem.Text = "Genero";
            this.generoToolStripMenuItem.Click += new System.EventHandler(this.generoToolStripMenuItem_Click_1);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(138, 28);
            this.editorialToolStripMenuItem.Text = "Editorial";
            this.editorialToolStripMenuItem.Click += new System.EventHandler(this.editorialToolStripMenuItem_Click_1);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(138, 28);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click_1);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem1});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // librosToolStripMenuItem1
            // 
            this.librosToolStripMenuItem1.Name = "librosToolStripMenuItem1";
            this.librosToolStripMenuItem1.Size = new System.Drawing.Size(126, 28);
            this.librosToolStripMenuItem1.Text = "Libros";
            this.librosToolStripMenuItem1.Click += new System.EventHandler(this.librosToolStripMenuItem1_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(59, 28);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIBLIOTECA POPULAR ALBERDI";
            // 
            // PPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(751, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(menuStrip1);
            this.MainMenuStrip = menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "PPrin";
            this.Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem conexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem1;
    }
}

