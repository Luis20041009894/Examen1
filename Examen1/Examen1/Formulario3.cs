using System;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Formulario3 : Form
    {

        public Formulario3()
        {
            InitializeComponent();
        }

        private void Formulario3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    MultiplosListBox.Items.Add("Luis Rodriguez");
                }
                else if (i % 3 == 0)
                {
                    MultiplosListBox.Items.Add("Luis");
                }
                else if (i % 5 == 0)
                {
                    MultiplosListBox.Items.Add("Rodriguez");
                }
                else
                {
                    MultiplosListBox.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
