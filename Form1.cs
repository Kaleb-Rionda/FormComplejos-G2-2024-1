using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormComplejos_G2_2024_1
{
    public partial class Form1 : Form
    {
        Complejo c1;
        Complejo c2;
        Complejo c3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma1_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbR1.Text), float.Parse(txtbIm1.Text));
            c2 = new Complejo(float.Parse(txtbR2.Text), float.Parse(txtbIm2.Text));
            c3 = c1 + c2;
            lbSuma1.Text = c3.ToString();
        }

        private void btnConjugar_Click(object sender, EventArgs e)
        {
            lbSuma1.Text = (~c3).ToString(); 
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbR1.Text), float.Parse(txtbIm1.Text));
            c2 = new Complejo(float.Parse(txtbR2.Text), float.Parse(txtbIm2.Text));
            c3 = c1 - c2;
            lbSuma1.Text = c3.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbR1.Text), float.Parse(txtbIm1.Text));
            c2 = new Complejo(float.Parse(txtbR2.Text), float.Parse(txtbIm2.Text));
            c3 = c1 * c2;
            lbSuma1.Text = c3.ToString();
        }
    }
}
