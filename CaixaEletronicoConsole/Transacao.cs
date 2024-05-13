using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoConsole
{
    public class Transacao
    {
        public double valor;
        public char tipo;
        public Transacao duplicata;
        public Conta conta;

        public Transacao(double valor, char tipo, Conta conta)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.conta = conta;
        }
    }
}
