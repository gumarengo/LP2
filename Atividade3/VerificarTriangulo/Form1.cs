using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificarTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;

            if (double.TryParse(txtLadoA.Text, out ladoA) && double.TryParse(txtLadoB.Text, out ladoB) && double.TryParse(txtLadoC.Text, out ladoC))
            {
                if (ladoA > 0 && ladoB > 0 && ladoC > 0)
                {
                   // if((Math.Abs(ladoB - ladoC) < ladoA < ladoB + ladoC) && (| ladoA - ladoC |< ladoB < ladoA + ladoC) && (| ladoA - ladoB |< ladoC < ladoA + ladoB))
                    if (ladoA.Equals(ladoB) && ladoA.Equals(ladoC))
                    {
                        labelResultado.Text = "Triângulo Equilatero";
                    }
                    else if (ladoA.Equals(ladoB) || ladoA.Equals(ladoC) || ladoB.Equals(ladoC))
                    {
                        labelResultado.Text = "Triângulo Isósceles";
                    }
                    else { labelResultado.Text = "Triângulo Escaleno"; }
                }
                else
                {
                    MessageBox.Show("Insira valores maiores que ZERO");
                }
            }
            else
            {
                MessageBox.Show("Insira valores");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
            labelResultado.Text = "";
        }
    }
}
