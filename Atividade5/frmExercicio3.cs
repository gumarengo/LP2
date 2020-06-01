﻿using System;
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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int posicao;

            // r        ss
            // arara    assessoria
            // aaa      aeoria
            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            while (posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            // este botão faz o mesmo do botão acima, mas usando o método Replace
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray();   // joga a string para um array
            Array.Reverse(arr);     // invertendo o array
            s = "";
            foreach (char c in arr)
                s = s + c.ToString();
            MessageBox.Show(s);

            // ou
            string ss = txtPalavra1.Text;
            char[] arr1 = ss.ToCharArray();
            Array.Reverse(arr1);
            ss = new string(arr1);
            MessageBox.Show(ss);

            // exemplo do new string
            string s1 = new string('a', 7); // aaaaaaa
        }
    }
}
