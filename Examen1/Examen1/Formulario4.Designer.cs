namespace Examen1
{
    partial class Formulario4
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
            this.SalirButton = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.ResultadosListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(428, 244);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(130, 87);
            this.SalirButton.TabIndex = 5;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(428, 119);
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
            this.ResultadosListBox.Location = new System.Drawing.Point(120, 119);
            this.ResultadosListBox.Name = "ResultadosListBox";
            this.ResultadosListBox.Size = new System.Drawing.Size(292, 212);
            this.ResultadosListBox.TabIndex = 3;
            // 
            // Formulario4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.ResultadosListBox);
            this.Name = "Formulario4";
            this.Text = "Formulario4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.ListBox ResultadosListBox;
    }
}