using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_05_Atividade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = "";
            if (15 % 3 == 0)
            {
                resultado += "15 é divisível por 3";
            }
            if (15 % 4 == 0)
            {
                resultado += " e é divisivel por 4 também.";
            }
            MessageBox.Show(resultado);

            string divisivelPorTres = "";
            string divisivelPorQuatro = "";
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    divisivelPorTres += i + ", ";
                }
                if (i % 4 == 0)
                {
                    divisivelPorQuatro += i + ", ";
                }
            }
            MessageBox.Show("De 0 até 30.\nAqui estão os números divisíveis por 3: " + divisivelPorTres + "\nAqui estão os números divisíveis por 4: " + divisivelPorQuatro);
        }
    }
}
