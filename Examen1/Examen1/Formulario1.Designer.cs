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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InteresListBox);
            this.Name = "Formulario1";
            this.Text = "Formulario1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InteresListBox;
        private System.Windows.Forms.Button button1;
    }
}