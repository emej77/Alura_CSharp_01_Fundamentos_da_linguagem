using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07_Atividade_08
{
    class Conta
    {
        public int numeroDaConta;
        public string titularDaConta;
        public double saldoDaConta;

        public void Saca(double valorASacar)
        {
            if ( (valorASacar > 0) && (this.saldoDaConta >= valorASacar) )
            {
                this.saldoDaConta -= valorASacar;
            }
        }

        public void Deposita(double valorADepositar)
        {
            if (valorADepositar > 0)
            {
                this.saldoDaConta += valorADepositar;
            }
        }
    }
}
