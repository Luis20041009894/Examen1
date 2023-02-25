namespace Examen1
{
    partial class Formulario3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario3));
            this.MultiplosListBox = new System.Windows.Forms.ListBox();
            this.GenerarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MultiplosListBox
            // 
            this.MultiplosListBox.FormattingEnabled = true;
            this.MultiplosListBox.ItemHeight = 16;
            this.MultiplosListBox.Location = new System.Drawing.Point(323, 12);
            this.MultiplosListBox.Name = "MultiplosListBox";
            this.MultiplosListBox.Size = new System.Drawing.Size(172, 388);
            this.MultiplosListBox.TabIndex = 0;
            // 
            // GenerarButton
            // 
            this.GenerarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarButton.Location = new System.Drawing.Point(516, 72);
            this.GenerarButton.Name = "GenerarButton";
            this.GenerarButton.Size = new System.Drawing.Size(92, 93);
            this.GenerarButton.TabIndex = 1;
            this.GenerarButton.Text = "Generar";
            this.GenerarButton.UseVisualStyleBackColor = true;
            this.GenerarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SalirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.Location = new System.Drawing.Point(516, 245);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(92, 93);
            this.SalirButton.TabIndex = 2;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 388);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Formulario3
            // 
            this.AcceptButton = this.GenerarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SalirButton;
            this.ClientSize = new System.Drawing.Size(620, 425);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.GenerarButton);
            this.Controls.Add(this.MultiplosListBox);
            this.Name = "Formulario3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario3";
            this.Load += new System.EventHandler(this.Formulario3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MultiplosListBox;
        private System.Windows.Forms.Button GenerarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}