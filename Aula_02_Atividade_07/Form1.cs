using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_02_Atividade_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeLuciana = 40;
            int idadeAdelina = 65;
            int idadeElias = 39;

            int idadeMedia = (idadeLuciana + idadeAdelina + idadeElias) / 3;

            MessageBox.Show("A idade média entre Luciana, Adelina e Elias é de: " + idadeMedia);
        }
    }
}
