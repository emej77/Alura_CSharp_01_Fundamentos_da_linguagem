using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_07_Atividade_02
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
            contaGuilherme.titularDaConta = "Guilherme";
            contaGuilherme.saldoDaConta = 1500.0;

            Conta contaMauricio = new Conta();
            contaMauricio.numeroDaConta = 1;
            contaMauricio.titularDaConta = "Mauricio";
            contaMauricio.saldoDaConta = 2500.0;

            contaGuilherme.Transfere(200.0, contaMauricio);

            MessageBox.Show("Saldo Guilherme: " + contaGuilherme.saldoDaConta + "\nSaldo Mauricio: " + contaMauricio.saldoDaConta);
        }
    }
}
