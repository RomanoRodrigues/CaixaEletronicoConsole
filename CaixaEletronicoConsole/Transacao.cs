using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoConsole
{
    public class Transacao
    {
        public double valor;
        public char tipo;
        public Transacao duplicata;
        public Transacao(double valor, char tipo)
        {
            this.valor = valor;
            this.tipo = tipo;
        }
    }
}
