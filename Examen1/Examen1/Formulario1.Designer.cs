﻿namespace Examen1
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
            this.InteresListBox = new System.Windows.Forms.ListBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InteresListBox
            // 
            this.InteresListBox.FormattingEnabled = true;
            this.InteresListBox.ItemHeight = 16;
            this.InteresListBox.Location = new System.Drawing.Point(43, 52);
            this.InteresListBox.Name = "InteresListBox";
            this.InteresListBox.Size = new System.Drawing.Size(209, 212);
            this.InteresListBox.TabIndex = 0;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(258, 52);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(130, 87);
            this.CalcularButton.TabIndex = 1;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(258, 177);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(130, 87);
            this.SalirButton.TabIndex = 2;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 349);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.InteresListBox);
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InteresListBox;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button SalirButton;
    }
}