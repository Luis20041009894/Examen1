using System;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Formulario1 : Form
    {




        public Formulario1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variables
            const double Capital = 200000.00;
            const double Interes = 0.015;
            double interesAcumulado = 0;
            double SaldoMensual = 200000.00;

            // Limpiar ListBox
            InteresListBox.Items.Clear();

            // Calcular interés mensual
            double interesMensual = Capital * Interes;


            for (int i = 1; i <= 12; i++)
            {
                double ahorroMensual = Capital + interesAcumulado + interesMensual;
                InteresListBox.Items.Add(getNombreMes(i) + " : " + " L." + ahorroMensual.ToString());

                // Actualizar interés acumulado
                interesAcumulado += interesMensual;


            }
        }

        private string getNombreMes(int mes)
        {
            switch (mes)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


