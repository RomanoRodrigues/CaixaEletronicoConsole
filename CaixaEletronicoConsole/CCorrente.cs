using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CaixaEletronicoConsole
{
    public class CCorrente
    {
        public string numero;
        public double saldo;
        public double limite;
        public bool status;
        public bool especial;
        public List<Transacao> transacoes;

        public CCorrente()
        {
            this.status = true;
            this.saldo = 0;
            transacoes = new List<Transacao>();
        }
        public CCorrente(string numero, double limite) : this()
        {
            this.numero = numero;
            this.limite = limite;
        }

        bool Sacar(double valor)
        {
            if (saldo - valor > -limite)
            {
                saldo -= valor;
                transacoes.Add(new Transacao(valor, 's'));
                return true;
            }
            return false;
        }

        bool Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                transacoes.Add(new Transacao(valor, 'd'));
                return true;
            }
            return false;
        }

        bool Transferir(CCorrente destino, double valor)
        {
            if (destino.status && Sacar(valor) && destino.Depositar(valor))
            {
                transacoes[transacoes.Count - 1].duplicata = destino.transacoes[destino.transacoes.Count - 1];
                destino.transacoes[destino.transacoes.Count - 1].duplicata = transacoes[transacoes.Count - 1];
                return true;
            }
            return false;
        }
    }
}