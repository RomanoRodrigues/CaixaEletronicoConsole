using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoConsole
{
    public class Conta
    {
        public string numero;
        public double saldo;
        public double limite;
        public bool status;

        public Conta()
        {

        }
        public Conta(string numero, double saldo, double limite, bool status)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.limite = limite;
            this.status = status;
        }

         public bool Sacar(double valor)
        {
            if (saldo - valor > -limite)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            return false;
        }

        public bool Transferir(Conta destino, double valor)
        {
            if (destino.status && Sacar(valor))
            {
                destino.Depositar(valor);
                return true;
            }
            return false;
        }
    }
}
