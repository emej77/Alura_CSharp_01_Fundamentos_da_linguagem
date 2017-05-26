using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03_Atividade_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 1500.0;
            double valorImposto;

            if (valorDaNotaFiscal < 1000)
            {
                valorImposto = valorDaNotaFiscal * 0.02;
            }
            else if ( (valorDaNotaFiscal >= 1000) || (valorDaNotaFiscal < 3000) )
            {
                valorImposto = valorDaNotaFiscal * 0.025;
            }
            else if ( (valorDaNotaFiscal >= 3000) || (valorDaNotaFiscal < 7000) )
            {
                valorImposto = valorDaNotaFiscal * 0.028;
            }
            else
            {
                valorImposto = valorDaNotaFiscal * 0.03;
            }

            // ou poderia ser desta forma abaixo
            /*
            if (valorDaNotaFiscal < 1000)
            {
                valorImposto = valorDaNotaFiscal * 0.02;
            }
            else if (valorDaNotaFiscal < 3000)
            {
                valorImposto = valorDaNotaFiscal * 0.025;
            }
            else if (valorDaNotaFiscal < 7000)
            {
                valorImposto = valorDaNotaFiscal * 0.028;
            }
            else
            {
                valorImposto = valorDaNotaFiscal * 0.03;
            }
            /**/
            MessageBox.Show("O imposto a pagar é de: " + valorImposto);
        }
    }
}
