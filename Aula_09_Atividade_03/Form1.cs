using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_09_Atividade_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaGuilherme = new Conta();
            contaGuilherme.numeroDaConta = 1;
            contaGuilherme.saldoDaConta = 1500.0;

            Cliente clienteGuilherme = new Cliente();
            clienteGuilherme.nome = "Guilherme";
            clienteGuilherme.idade = 17;

            contaGuilherme.titularDaConta = clienteGuilherme;

            bool sacou = contaGuilherme.Saca(200.01);//testando idade
            if (sacou)
            {
                MessageBox.Show("Saldo da Conta do Guilherme após saque: " + contaGuilherme.saldoDaConta);
            }
            else
            {
                MessageBox.Show("Não foi possível sacar da conta do Guilherme");
            }
        }
    }
}
