using System;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ejecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario1 formulario1 = new Formulario1();
            formulario1.Show();

        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario2 formulario2 = new Formulario2();
            formulario2.Show();
        }

        private void formulario3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario3 formulario3 = new Formulario3();
            formulario3.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formulario1 formulario1 = new Formulario1();
            formulario1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formulario2 formulario2 = new Formulario2();
            formulario2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formulario3 formulario3 = new Formulario3();
            formulario3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
