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
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.TipoProductoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoDataGridView = new System.Windows.Forms.DataGridView();
            this.PagarBbutton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.TotalPagarLabel = new System.Windows.Forms.Label();
            this.DescuentoLabel = new System.Windows.Forms.Label();
            this.TotalVentaLabel = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(145, 159);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(146, 22);
            this.PrecioTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(145, 109);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(146, 22);
            this.CantidadTextBox.TabIndex = 15;
            // 
            // TipoProductoTextBox
            // 
            this.TipoProductoTextBox.Location = new System.Drawing.Point(145, 62);
            this.TipoProductoTextBox.Name = "TipoProductoTextBox";
            this.TipoProductoTextBox.Size = new System.Drawing.Size(146, 22);
            this.TipoProductoTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo Producto:";
            // 
            // ProductoDataGridView
            // 
            this.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.cantidad,
            this.precio});
            this.ProductoDataGridView.Location = new System.Drawing.Point(20, 213);
            this.ProductoDataGridView.Name = "ProductoDataGridView";
            this.ProductoDataGridView.RowHeadersWidth = 51;
            this.ProductoDataGridView.RowTemplate.Height = 24;
            this.ProductoDataGridView.Size = new System.Drawing.Size(760, 177);
            this.ProductoDataGridView.TabIndex = 11;
            this.ProductoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductoDataGridView_CellContentClick);
            // 
            // PagarBbutton
            // 
            this.PagarBbutton.Location = new System.Drawing.Point(333, 121);
            this.PagarBbutton.Name = "PagarBbutton";
            this.PagarBbutton.Size = new System.Drawing.Size(75, 54);
            this.PagarBbutton.TabIndex = 10;
            this.PagarBbutton.Text = "Pagar";
            this.PagarBbutton.UseVisualStyleBackColor = true;
            this.PagarBbutton.Click += new System.EventHandler(this.PagarBbutton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(333, 61);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 54);
            this.AgregarButton.TabIndex = 9;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // TotalPagarLabel
            // 
            this.TotalPagarLabel.AutoSize = true;
            this.TotalPagarLabel.Location = new System.Drawing.Point(477, 148);
            this.TotalPagarLabel.Name = "TotalPagarLabel";
            this.TotalPagarLabel.Size = new System.Drawing.Size(91, 16);
            this.TotalPagarLabel.TabIndex = 20;
            this.TotalPagarLabel.Text = "Total a pagar:";
            // 
            // DescuentoLabel
            // 
            this.DescuentoLabel.AutoSize = true;
            this.DescuentoLabel.Location = new System.Drawing.Point(485, 100);
            this.DescuentoLabel.Name = "DescuentoLabel";
            this.DescuentoLabel.Size = new System.Drawing.Size(75, 16);
            this.DescuentoLabel.TabIndex = 19;
            this.DescuentoLabel.Text = "Descuento:";
            // 
            // TotalVentaLabel
            // 
            this.TotalVentaLabel.AutoSize = true;
            this.TotalVentaLabel.Location = new System.Drawing.Point(483, 52);
            this.TotalVentaLabel.Name = "TotalVentaLabel";
            this.TotalVentaLabel.Size = new System.Drawing.Size(79, 16);
            this.TotalVentaLabel.TabIndex = 18;
            this.TotalVentaLabel.Text = "Total Venta:";
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 125;
            // 
            // Formulario4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalPagarLabel);
            this.Controls.Add(this.DescuentoLabel);
            this.Controls.Add(this.TotalVentaLabel);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.TipoProductoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductoDataGridView);
            this.Controls.Add(this.PagarBbutton);
            this.Controls.Add(this.AgregarButton);
            this.Name = "Formulario4";
            this.Text = "Formulario4";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.TextBox TipoProductoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductoDataGridView;
        private System.Windows.Forms.Button PagarBbutton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Label TotalPagarLabel;
        private System.Windows.Forms.Label DescuentoLabel;
        private System.Windows.Forms.Label TotalVentaLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}