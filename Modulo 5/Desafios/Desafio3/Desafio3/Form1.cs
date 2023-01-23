using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desafio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            resultado.Text = "Su resultado es:";
            operacion.Text = Convert.ToString(Convert.ToDouble(numero1.Text) + Convert.ToDouble(numero2.Text));
        }

        private void restar_Click(object sender, EventArgs e)
        {
            resultado.Text = "Su resultado es:";
            operacion.Text = Convert.ToString(Convert.ToDouble(numero1.Text) - Convert.ToDouble(numero2.Text));
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            resultado.Text = "Su resultado es:";
            operacion.Text = Convert.ToString(Convert.ToDouble(numero1.Text) * Convert.ToDouble(numero2.Text));
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            resultado.Text = "Su resultado es:";
            operacion.Text = Convert.ToString(Convert.ToDouble(numero1.Text) / Convert.ToDouble(numero2.Text));
        }
    }
}
