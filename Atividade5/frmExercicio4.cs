using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenus
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCaractNum_Click(object sender, EventArgs e)
        {
            // dias 10 melhores 1000 - 21 caracteres
            int contador = 0;

            for (var x = 0; x <= rchtxtTexto.Text.Length - 1; x++)
            {
                // if (Char.IsNumber(Convert.ToChar(rchtxtTexto.Text.Substring(x, 1))))
                if (Char.IsNumber(rchtxtTexto.Text[x]))
                    contador += 1;
            }
            MessageBox.Show("Caracteres numericos: " + contador);
        }

        private void btnPrimBranco_Click(object sender, EventArgs e)
        {
            int x = 0;
            // hoje tem sol
            
            while (x < rchtxtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro caracter branco: " + (x + 1));
                    break;
                }
                x += 1;
            }
        }

        private void btnCaractAlfab_Click(object sender, EventArgs e)
        {
            // vejo flores em voce

            int contador = 0;
            foreach (char c in rchtxtTexto.Text)
            {
                if (Char.IsLetter(c))   // apenas letras, ignora numeros e espaços
                    contador += 1;
            }
            MessageBox.Show("Caracteres Alfabeticos: " + contador);
        }
    }
}
