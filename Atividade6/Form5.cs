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
    public partial class frmEx4 : Form
    {
        public frmEx4()
        {
            InitializeComponent();
        }

        private void btnSalBruto_Click(object sender, EventArgs e)
        {
            int B = 0, C = 0, D = 0;
            double salBruto, gratif = 0;

            if (double.TryParse(txtSalario.Text, out double salario) &&
                double.TryParse(txtGratif.Text, out gratif) &&
                int.TryParse(txtProd.Text, out int prod))
            {
                if (prod >= 150) D = 1;
                if (prod >= 120) C = 1;
                if (prod >= 100) B = 1;
                salBruto = salario + salario * (0.05 * B + 0.1 * C + 0.1 * D) + gratif;
                if (salBruto > 7000)
                {
                    if (prod < 150 || gratif == 0) salBruto = 7000.00;
                }
                MessageBox.Show("Salário Bruto: " + salBruto.ToString("N2"));
            }
            else
                MessageBox.Show("Dados inválidos!");
        }
    }
}
