using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04_Atividade_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serieFibonacci = "";
            double atual = 1;
            double anterior = 0;
            for (int i = 1; i <= 100; i++)
            {
                serieFibonacci += atual + ", ";
                double proximo = atual + anterior;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibonacci);
        }
    }
}
