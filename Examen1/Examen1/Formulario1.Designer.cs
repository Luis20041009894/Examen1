namespace Examen1
{
    partial class Formulario1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario1));
            this.SalirButton = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.ResultadosListBox = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SalirButton
            // 
            this.SalirButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SalirButton.Location = new System.Drawing.Point(604, 201);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(130, 87);
            this.SalirButton.TabIndex = 5;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(604, 12);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(130, 87);
            this.CalcularButton.TabIndex = 4;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // ResultadosListBox
            // 
            this.ResultadosListBox.FormattingEnabled = true;
            this.ResultadosListBox.ItemHeight = 16;
            this.ResultadosListBox.Location = new System.Drawing.Point(426, 12);
            this.ResultadosListBox.Name = "ResultadosListBox";
            this.ResultadosListBox.Size = new System.Drawing.Size(172, 276);
            this.ResultadosListBox.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(399, 276);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Formulario1
            // 
            this.AcceptButton = this.CalcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SalirButton;
            this.ClientSize = new System.Drawing.Size(746, 313);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.ResultadosListBox);
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.ListBox ResultadosListBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}