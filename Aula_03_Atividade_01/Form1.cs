using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03_Atividade_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Valores para if
            /*
            double saldo = 100.0;
            double valor = 10.0;
            /**/

            //Valores para else
            /**/
            double saldo = 100.0;
            double valor = 110.0;
            /**/

            bool podeSacar = (valor <= saldo) && (valor > 0);

            if (podeSacar)
            {
                saldo = saldo - valor;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }
    }
}
