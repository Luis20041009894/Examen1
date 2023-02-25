namespace Examen1
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulario1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulario2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulario3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulario4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulario1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulario1ToolStripMenuItem
            // 
            this.formulario1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem,
            this.formulario2ToolStripMenuItem,
            this.formulario3ToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.formulario4ToolStripMenuItem});
            this.formulario1ToolStripMenuItem.Name = "formulario1ToolStripMenuItem";
            this.formulario1ToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.formulario1ToolStripMenuItem.Text = "Seleccione Formulario:";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ejecutarToolStripMenuItem.Text = "Formulario1";
            this.ejecutarToolStripMenuItem.Click += new System.EventHandler(this.ejecutarToolStripMenuItem_Click);
            // 
            // formulario2ToolStripMenuItem
            // 
            this.formulario2ToolStripMenuItem.Name = "formulario2ToolStripMenuItem";
            this.formulario2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.formulario2ToolStripMenuItem.Text = "Formulario2";
            this.formulario2ToolStripMenuItem.Click += new System.EventHandler(this.formulario2ToolStripMenuItem_Click);
            // 
            // formulario3ToolStripMenuItem
            // 
            this.formulario3ToolStripMenuItem.Name = "formulario3ToolStripMenuItem";
            this.formulario3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.formulario3ToolStripMenuItem.Text = "Formulario3";
            this.formulario3ToolStripMenuItem.Click += new System.EventHandler(this.formulario3ToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // formulario4ToolStripMenuItem
            // 
            this.formulario4ToolStripMenuItem.Name = "formulario4ToolStripMenuItem";
            this.formulario4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.formulario4ToolStripMenuItem.Text = "Formulario4";
            this.formulario4ToolStripMenuItem.Click += new System.EventHandler(this.formulario4ToolStripMenuItem_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 349);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulario1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulario2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulario3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulario4ToolStripMenuItem;
    }
}

