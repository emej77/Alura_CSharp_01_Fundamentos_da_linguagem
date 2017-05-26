using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04_Atividade_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorInvestido = 2000.0;

            // utilizando o for
            for (int i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.01;
            }

            MessageBox.Show("O valor investido agora é: " + valorInvestido);

            //utilizando o while
            valorInvestido = 2000.0;

            int j = 1;
            while (j <=12)
            {
                valorInvestido *= 1.01;
                j++;
            }
            MessageBox.Show("O valor investido agora é: " + valorInvestido);
        }
    }
}
