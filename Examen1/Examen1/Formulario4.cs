using System;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Formulario4 : Form
    {
        public Formulario4()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            CalcularInteres();

        }
        private void CalcularInteres()
        {
            double capital = 200000.00;
            double interesAcumulado = 0.00;
            double tasaInteres = 0.015;
            int meses = 12;

            ResultadosListBox.Items.Clear();

            for (int i = 1; i <= meses; i++)
            {
                double interesMes = capital * tasaInteres;
                interesAcumulado += interesMes;
                capital += interesMes;
                ResultadosListBox.Items.Add($"{ObtenerNombreMes(i)}: {capital:C}");
            }
        }
        private string ObtenerNombreMes(int numeroMes)
        {

            switch (numeroMes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    return "";

            }
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

