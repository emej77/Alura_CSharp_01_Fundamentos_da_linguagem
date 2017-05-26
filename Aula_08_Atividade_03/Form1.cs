using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_08_Atividade_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente clienteElias = new Cliente();
            clienteElias.cpf = "123456789-12";
            clienteElias.nome = "Elias Mansur Espindola Junior";
            clienteElias.endereco = "Rua das Flores, 869";

            Conta contaElias = new Conta();
            contaElias.agencia = 123;
            contaElias.numero = 456789;
            contaElias.titular = clienteElias;

            MessageBox.Show("O titular da conta " + contaElias.numero + " é o(a) " + contaElias.titular.nome);
        }
    }
}
