﻿using System;
using System.Globalization;
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
            DateTimeFormatInfo dtinfo = new CultureInfo("es-HN", false).DateTimeFormat;
            return dtinfo.GetMonthName(numeroMes);
        }
    }
}
