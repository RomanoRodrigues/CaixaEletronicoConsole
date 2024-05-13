namespace CaixaEletronicoConsole
{
    public class CCorrente : Conta
    {
        public bool especial;

        public CCorrente()
        {
            especial = false;
        }
        public CCorrente(string numero, double limite)
        {
            this.numero = numero;
            this.limite = limite;
        }
    }

}