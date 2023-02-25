namespace Examen1
{
    internal class Producto
    {
        //Atributos
        private string tipo;
        private int cantidad;
        private decimal precio;
        private decimal subtotal;
        private double descuento;


        //Propiedades
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
        public double Descuento { get; set; }

        //Constructor

        public Producto() { }

        public Producto(string tipo, int cantidad, decimal precio, decimal subtotal, double descuento, decimal total)
        {
            Tipo = tipo;
            Cantidad = cantidad;
            Precio = precio;
            Subtotal = subtotal;
            Descuento = descuento;

        }

        //Metodos
        public string DevolverDAtosBasicos()
        {
            return "Tipo: " + Tipo + " Cantidad: " + Cantidad + " Precio: " + Precio + " Subtotal: " + Descuento + "Descuento: ";

        }

    }
}
