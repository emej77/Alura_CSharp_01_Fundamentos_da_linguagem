using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07_Atividade_02
{
    class Conta
    {
        public int numeroDaConta;
        public string titularDaConta;
        public double saldoDaConta;

        public void Saca(double valor)
        {
            this.saldoDaConta -= valor;
        }

        public void Deposita(double valor)
        {
            this.saldoDaConta += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
