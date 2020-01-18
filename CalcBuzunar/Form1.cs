using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcBuzunar
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonAdunare_Click(object sender, EventArgs e)
        {
            int rezultat = Convert.ToInt32(textBoxSus.Text) + Convert.ToInt32(textBoxJos.Text);
            textBoxRezultat.Text = rezultat.ToString();
        }

        private void buttonScadere_Click(object sender, EventArgs e)
        {
            int rezultat = Convert.ToInt32(textBoxSus.Text) - Convert.ToInt32(textBoxJos.Text);
            textBoxRezultat.Text = rezultat.ToString();
        }

        private void buttonInmultire_Click(object sender, EventArgs e)
        {
            int rezultat = Convert.ToInt32(textBoxSus.Text)*Convert.ToInt32(textBoxJos.Text);
            textBoxRezultat.Text = rezultat.ToString();
        }

        private void buttonImpartirea_Click(object sender, EventArgs e)
        {
            double rezultat = Convert.ToDouble(textBoxSus.Text)/Convert.ToDouble(textBoxJos.Text);
            textBoxRezultat.Text = rezultat.ToString();
        }


    }
}
