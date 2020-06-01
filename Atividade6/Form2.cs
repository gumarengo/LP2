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
    public partial class frmEx1 : Form
    {
        public frmEx1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int i = 0, count = 0;

            while (i < rchtxtTexto.Text.Length)
            {
                if (char.IsWhiteSpace(rchtxtTexto.Text[i]))
                {
                    count++;
                }
                i++;
            }
            MessageBox.Show("Total de espaços em branco: " + count);
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int count = 0;

            for (var i = 0; i < rchtxtTexto.Text.Length; i++)
            {
                if (rchtxtTexto.Text[i] == 'R' || rchtxtTexto.Text[i] == 'r')
                {
                    count++;
                }
            }
            MessageBox.Show("Total de letras R: " + count);
        }

        private void btnParLetras_Click(object sender, EventArgs e)
        {
            int count = 0;
            string letra = "";

            for (var i = 0; i < rchtxtTexto.Text.Length; i++)
            {
                if ((rchtxtTexto.Text.Substring(i, 1) != "") &&
                        (rchtxtTexto.Text.Substring(i, 1) == letra))
                {
                    count++;
                }
                letra = rchtxtTexto.Text.Substring(i, 1);
            }
            MessageBox.Show("Total de par de letras: " + count);
        }
    }
}
