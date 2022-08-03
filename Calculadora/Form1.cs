using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);
            resultado = numero1 + numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);
            resultado = numero1 - numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btMultiplica_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);
            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);
            resultado = numero1 / numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
