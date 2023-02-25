using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (TipoProductoTextBox.Text == "")
            {
                errorProvider1.SetError(TipoProductoTextBox, "Ingrese Porducto");
                return;
            }
            errorProvider1.Clear();
            if (CantidadTextBox.Text == "")
            {
                errorProvider1.SetError(CantidadTextBox, "Favor ingresar una cantidad mayor a 1");
                CantidadTextBox.Focus();
                return;

            }
            errorProvider1.Clear();

            if (PrecioTextBox.Text == "")
            {
                errorProvider1.SetError(PrecioTextBox, "Favor ingresar un precio");
                PrecioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            string producto = TipoProductoTextBox.Text;
            decimal precio = PrecioTextBox.Text == string.Empty ? 1 : Convert.ToDecimal(PrecioTextBox.Text);
            int cantidad = CantidadTextBox.Text == string.Empty ? 1 : Convert.ToInt32(CantidadTextBox.Text);


            ProductoDataGridView.Rows.Add(producto, cantidad, precio);

            LimpiarControles();
            TipoProductoTextBox.Focus();

        }
        private async Task<decimal> CalcularDescuento(decimal total)
        {
            await Task.Delay(1000); // Simula una operación asíncrona
            return total * 0.15m;
        }
        private async void PagarBbutton_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in ProductoDataGridView.Rows)
            {
                decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                total += precio * cantidad;
            }

            decimal descuento = await CalcularDescuento(total);
            decimal totalPagar = total - descuento;

            TotalVentaLabel.Text = $"Total de la venta: {total:0.00}";
            DescuentoLabel.Text = $"Descuento del 15%: {descuento:0.00}";
            TotalPagarLabel.Text = $"Total a pagar: {totalPagar:0.00}";

        }
        private void LimpiarControles()
        {
            TipoProductoTextBox.Clear();
            PrecioTextBox.Clear();
            CantidadTextBox.Clear();
        }



        private void ProductoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
                e.Handled = true;
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
