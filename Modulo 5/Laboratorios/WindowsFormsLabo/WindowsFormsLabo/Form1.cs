using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsLabo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            resultado.Text = Convert.ToString((Convert.ToDouble(nota1.Text)+Convert.ToDouble(nota2.Text))/2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
