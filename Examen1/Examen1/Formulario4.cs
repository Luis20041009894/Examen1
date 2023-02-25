using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Formulario4 : Form
    {
        public Formulario4()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            string producto = TipoProductoTextBox.Text;
            decimal precio = Convert.ToDecimal(PrecioTextBox.Text);
            int cantidad = Convert.ToInt32(CantidadTextBox.Text);

            ProductoDataGridView.Rows.Add(producto, precio, cantidad);

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
    }
}
