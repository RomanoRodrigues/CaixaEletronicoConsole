public class CCorrente
{
    public string numero;
    public double saldo;
    public double limite;
    public bool status;
    public bool especial;

    public CCorrente(string numero, double limite)
    {
        this.numero = numero;
        this.limite = limite;
        this.saldo = 0; // Inicializa o saldo como 0
        this.status = true; // Define o status como ativo por padrão
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

    public bool Transferir(CCorrente destino, double valor)
    {
        if (destino.status && Sacar(valor))
        {
            destino.Depositar(valor);
            return true;
        }
        return false;
    }
}