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
            this.MultiplosListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MultiplosListBox
            // 
            this.MultiplosListBox.FormattingEnabled = true;
            this.MultiplosListBox.ItemHeight = 16;
            this.MultiplosListBox.Location = new System.Drawing.Point(12, 21);
            this.MultiplosListBox.Name = "MultiplosListBox";
            this.MultiplosListBox.Size = new System.Drawing.Size(172, 388);
            this.MultiplosListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 79);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Formulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MultiplosListBox);
            this.Name = "Formulario3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario3";
            this.Load += new System.EventHandler(this.Formulario3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MultiplosListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}