using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso, altura, imc = 0;

            if (double.TryParse(textPeso.Text, out peso) && double.TryParse(textAltura.Text, out altura))
            {
                if (radioMasc.Checked)
                {
                    imc = Math.Round((72.7 * altura) - 58.0,1);
                }
                else if (radioFem.Checked)
                {
                    imc = Math.Round((62.1 * altura) - 44.7,1);
                }
                else
                    MessageBox.Show("Selecione Sexo");

                maskedIMC.Text = imc.ToString();

                if (imc < peso)
                {
                    labelAVISO.Text = "Regime obrigatório já!"; labelAVISO.ForeColor = Color.Red;
                }
                else if (imc > peso)
                {
                    labelAVISO.Text = "Coma bastante massas e doces"; labelAVISO.ForeColor = Color.Orange;
                }
                else if (imc == (peso)) 
                {
                    labelAVISO.Text = "Você está no peso ideal"; labelAVISO.ForeColor = Color.Green; 
                }
            }
            else
            {
                MessageBox.Show("Insira valores");
            }

           
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
