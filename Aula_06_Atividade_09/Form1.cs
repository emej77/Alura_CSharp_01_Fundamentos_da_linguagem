using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Atividade_09
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
            umaConta.titularDaConta = "Luciana Polachini";
            umaConta.saldoDaConta = 32541.26;
            MessageBox.Show("O nome do titular da conta é: " + umaConta.titularDaConta);
        }
    }
}
