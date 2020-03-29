using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensalista mensalista = new Mensalista();
            mensalista.NomeEmpregado = txtNome.Text;
            mensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            mensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            mensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);

           MessageBox.Show("Nome=" + mensalista.NomeEmpregado + "\n" + "Matricula=" + mensalista.Matricula + 
                "\n" + "Tempo Trabalho:" + mensalista.TempoTrabalho().ToString() + "\n" + "Salario final=" + 
                mensalista.SalarioBruto().ToString("N2")); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mensalista mensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text), txtNome.Text, Convert.ToDateTime(txtData.Text),Convert.ToDouble(txtSalario.Text));
            MessageBox.Show("Nome=" + mensalista.NomeEmpregado + "\n" + "Matricula=" + mensalista.Matricula + 
                "\n" + "Tempo Trabalho:" + mensalista.TempoTrabalho().ToString() + "\n" + "Salario final=" +
                mensalista.SalarioBruto().ToString("N2")); 

        }
    }
}
