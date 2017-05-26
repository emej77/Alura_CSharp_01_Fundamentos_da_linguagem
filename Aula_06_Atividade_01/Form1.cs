using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Atividade_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sem uma classe
            int numeroDaConta1 = 1;
            string titularDaConta1 = "Joaquim José";
            double saldoDaDonta1 = 2000.0;

            int numeroDaConta2 = 2;
            string titularDaConta2 = "Silva Andrade";
            double saldoDaDonta2 = 1500.0;


            //Com uma classe
            Conta umaConta = new Conta();
            umaConta.numeroDaConta = 1;
            umaConta.titularDaConta = "Joaquim José";
            umaConta.saldoDaConta = 2000.0;

            Conta outraConta = new Conta();
            outraConta.numeroDaConta = 2;
            outraConta.titularDaConta = "Silva Andrade";
            outraConta.saldoDaConta = 1500.0;

            MessageBox.Show("O titular da conta 1 é: " + umaConta.titularDaConta);
        }
    }
}
