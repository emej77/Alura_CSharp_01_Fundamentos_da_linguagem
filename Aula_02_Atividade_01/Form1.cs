using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_02_Atividade_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroDaConta = 1;

            double saldo = 100.0;
            double valorDoSaque = 10.0;
            double saldoAposSaque = saldo - valorDoSaque;

            MessageBox.Show("O saldo da conta após o saque é de: " + saldoAposSaque);
        }
    }
}
