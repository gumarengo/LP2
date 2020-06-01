using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade6
{
    public partial class frmEx3 : Form
    {
        public frmEx3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            txtFrase.Text = txtFrase.Text.ToUpper();
            txtFrase.Text = txtFrase.Text.Replace(" ", "");
            
            string s = txtFrase.Text;
            char[] invertido = s.ToCharArray();
            Array.Reverse(invertido);
            s = new string(invertido);

            if (s == txtFrase.Text)
                MessageBox.Show("É palíndromo!");
            else
                MessageBox.Show("Não é palíndromo!");
        }
    }
}
