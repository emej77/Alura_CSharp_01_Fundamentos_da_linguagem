using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09_Atividade_03
{
    class Conta
    {
        public int numeroDaConta;
        public Cliente titularDaConta;
        public double saldoDaConta;

        public bool Saca(double valor)
        {
            if ( (valor > this.saldoDaConta) && (valor <= 0) )
            {
                return false;
            }
            else
            {
                if (this.titularDaConta.ehMaiorDeIdade())
                {
                    this.saldoDaConta -= valor;
                    return true;
                }
                else
                {
                    if (valor <= 200)
                    {
                        this.saldoDaConta -= valor;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
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

        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.saldoDaConta;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.saldoDaConta;

            return rendimento;
        }
    }
}
