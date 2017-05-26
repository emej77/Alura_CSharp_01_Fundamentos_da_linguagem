using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03_Atividade_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = true;

            if (idade < 16)
            {
                MessageBox.Show("Você precisa ter no mínimo 16 anos para poder votar.");
            } else if (! brasileira)
            {
                MessageBox.Show("Você precisa ter nacionalidade brasileira para poder votar.");
            } else
            {
                MessageBox.Show("Voto computado com sucesso!");
            }
        }
    }
}
