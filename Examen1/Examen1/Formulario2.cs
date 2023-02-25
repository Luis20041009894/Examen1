using System;
using System.Collections.Generic;
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

        Producto miProducto = null;
        List<Producto> Listaproducto = new List<Producto>();


        private void Formulario2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = TipoProductoTextBox.Text;
            int cantidad = Convert.ToInt32(CantidadTextBox.Text);
            decimal precio = Convert.ToInt32(PrecioTextBox.Text);
            double subtotal = 0;
            double descuento = 0.15;


            //Instanciar
            miProducto = new Producto();
            miProducto.Tipo = tipo;
            miProducto.Cantidad = cantidad;
            miProducto.Precio = precio;
            miProducto.Subtotal = cantidad * precio;
            miProducto.Descuento = descuento;



            Listaproducto.Add(miProducto);
            ProductoDataGridView.DataSource = null;
            ProductoDataGridView.DataSource = Listaproducto;

        }

        private async Task<decimal> CalcularDescuento(decimal total)
        {
            await Task.Delay(1000); // Simula una operación asíncrona
            return total * 0.15m;
        }
        private async void PagarBbutton_Click(object sender, EventArgs e)
        {
            {
                string[] productos = TipoProductoTextBox.Text.Split(',');
                string[] precios = PrecioTextBox.Text.Split(',');
                string[] cantidades = CantidadTextBox.Text.Split(',');

                decimal total = 0;
                for (int i = 0; i < productos.Length; i++)
                {
                    decimal precio = decimal.Parse(precios[i]);
                    int cantidad = int.Parse(cantidades[i]);
                    total += precio * cantidad;
                }

                decimal descuento = await CalcularDescuento(total);
                decimal totalPagar = total - descuento;

                lblTotalVenta.Text = $"Total de la venta: {total:0.00}";
                lblDescuento.Text = $"Descuento del 15%: {descuento:0.00}";
                lblTotalPagar.Text = $"Total a pagar: {totalPagar:0.00}";
            }


        }


    }
}
