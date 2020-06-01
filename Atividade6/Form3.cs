using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade6
{
    public partial class frmEx2 : Form
    {
        public frmEx2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // H = 1 + 1/2 + 1/3 + 1/4 + ... + 1/N

            double H = 1;

            if (float.TryParse(txtN.Text, out float N))
            {
                for (int i = 2; i <= N; i++)
                {
                    H += (1.0 / i);
                }
                MessageBox.Show("O valor de H é: " + H.ToString("N3"));
            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }
        }
    }
}
