using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04_Atividade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorInvestimento = 1000.0;
            double porcentagem = 1.01;
            double valorInvestimentoFinal = 0;

            for (int i = 1; i <= 12; i++)
            {
                valorInvestimentoFinal += valorInvestimento;
                valorInvestimentoFinal *= porcentagem;
            }

            MessageBox.Show("O valor final do investimento é de: " + valorInvestimentoFinal);
        }
    }
}
