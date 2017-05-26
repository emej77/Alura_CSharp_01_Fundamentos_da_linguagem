using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_05_Atividade_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado = 0.0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    resultado += i;
                }
            }
            MessageBox.Show("A somatória dos valores de 1 até 100 pulando os multiplos de 3 é de: " + resultado);
        }
    }
}
