using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double verify1, verify2;

            if ((double.TryParse(textBox1.Text, out verify1)) && (double.TryParse(textBox2.Text, out verify2)))
            {
                double volume = Math.Pow(verify1, 2) * Math.PI * verify2;
                textBox3.Text = volume.ToString("N2");
            }
            else
                MessageBox.Show("Dados inválidos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        }
    }

