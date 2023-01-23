using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;

namespace Desafios
{
    public partial class Desafio1 : Form
    {
        public Desafio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string genero = "";
            string extranjero = "No";
            if(nombreAl.Text.Length == 0 || estadoCiv.Text.Length == 0 || !(hom.Checked || muj.Checked || nogen.Checked))
            {
                Alerta.ForeColor = Color.Red;
                Alerta.Text = "Le falta ingresar datos";
            }
            else
            {
                if (hom.Checked) genero = "Hombre";
                if (muj.Checked) genero = "Mujer";
                if (nogen.Checked) genero = "No Especifica";
                if (esEx.Checked) extranjero = "Si";
                dataGrid.Rows.Add(nombreAl.Text, fechaReg.Text, estadoCiv.Text, genero, extranjero);
                Alerta.ForeColor = Color.DarkGreen;
                Alerta.Text = "Enviado";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
