using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Atividade_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            umaConta.numeroDaConta = 1;
            umaConta.titularDaConta = "Elias Mansur Espindola Junior";
            umaConta.saldoDaConta = 1523.23;
            MessageBox.Show("O nome do titular da conta é: " + umaConta.titularDaConta);

            Conta outraConta = new Conta();
            outraConta.agenciaDaConta = 2677;
            outraConta.numeroDaConta = 14019;
            outraConta.cpfDoTitularDaConta = "524879654-21";
            outraConta.titularDaConta = "Luciana Polachini";
            outraConta.saldoDaConta = 542.95;
            MessageBox.Show("Outra Conta\nAgência:" + outraConta.agenciaDaConta + "\nConta: " + outraConta.numeroDaConta + "\nCPF: " + outraConta.cpfDoTitularDaConta + "\nTitular: " + outraConta.titularDaConta + "\nSaldo: " + outraConta.saldoDaConta);
        }
    }
}
