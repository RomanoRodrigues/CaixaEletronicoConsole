using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoConsole
{
    public class CPoupanca: Conta
    {
        public CPoupanca()
        {

        }
        public CPoupanca(string numero)
        {
            this.numero = numero;
        }
    }
}
