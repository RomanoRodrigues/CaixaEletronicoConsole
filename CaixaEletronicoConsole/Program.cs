List<CCorrente> contas = new List<CCorrente>();

menu(false);

void menu(bool tchau)
{
    Console.WriteLine("-MENU-");
    Console.WriteLine("1. Acesso Administrativo");
    Console.WriteLine("2. Caixa Eletrônico");
    Console.WriteLine("3. Sair");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            menuAdm();
            break;
        case 2:
            menuTeste();
            break;
        case 3:
            tchau = true;
            break;
    }
    if (tchau)
        return;
    menu(tchau);
}

void menuAdm()
{
    Console.WriteLine("-MENU ADM-");
    Console.WriteLine("1. Cadastro de Conta Corrente");
    Console.WriteLine("2. Mostrar os Saldos");
    Console.WriteLine("3. Excluir Conta");
    Console.WriteLine("4. Voltar");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            bool stop;
            string burro;
            Console.WriteLine("Número da conta: ");
            do
            {
                burro = Console.ReadLine();
                stop = true;
                foreach (CCorrente c in contas)
                {
                    if (burro == c.numero)
                        stop = false;
                }
                if (!stop)
                    Console.WriteLine("Conta Duplicada, tente novamente: ");
            } while (!stop);
            Console.WriteLine("Limite da conta: ");
            double limite = double.Parse(Console.ReadLine());
            contas.Add(new CCorrente(burro, limite));
            break;
        case 2:
            foreach (CCorrente c in contas)
            {
                Console.WriteLine("Saldo da conta " + c.numero + ": " + c.saldo);
            }
            break;
        case 3:
            bool stoop;
            Console.WriteLine("Número da conta: ");
            do
            {
                string burro2 = Console.ReadLine();
                stoop = true;
                foreach (CCorrente c in contas)
                {
                    if (burro2 == c.numero)
                    {
                        c.status = false;
                        stoop = false;
                        Console.WriteLine("Conta desativada com sucesso!");
                    }
                }
                if (stoop)
                    Console.WriteLine("Conta inexistente, tente novamente: ");
            } while (stoop);
            break;
        case 4:
            return;
    }
    menuAdm();
}

void menuTeste()
{
    Console.Write("Qual é a sua conta: ");
    bool find = false;
    string conta = Console.ReadLine();
    foreach (CCorrente c in contas)
    {
        if (c.status && c.numero == conta)
        {
            find = true;
            menuCaixa(c);
        }
    }
    if (!find)
    {
        Console.WriteLine("Essa conta foi desativada ou não existe");
        menuTeste();
    }
}

void menuCaixa(CCorrente conta)
{
    Console.WriteLine("-CAIXA ELETRÔNICO-");
    Console.WriteLine("1. Saque");
    Console.WriteLine("2. Depósito");
    Console.WriteLine("3. Transferência");
    Console.WriteLine("4. Voltar");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Console.WriteLine("Digite o valor para sacar:");
            if (double.TryParse(Console.ReadLine(), out double valorSaque))
            {
                if (conta.Sacar(valorSaque))
                {
                    Console.WriteLine("Saque realizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente ou limite excedido.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
            break;
        case 2:
            Console.WriteLine("Digite o valor para depositar:");
            if (double.TryParse(Console.ReadLine(), out double valorDeposito))
            {
                if (conta.Depositar(valorDeposito))
                {
                    Console.WriteLine("Depósito realizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Valor inválido para depósito.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
            break;
        case 3:
            Console.WriteLine("Digite o número da conta de destino:");
            string destinoTransferencia = Console.ReadLine();
            CCorrente contaDestino = contas.Find(c => c.numero == destinoTransferencia);

            if (contaDestino != null)
            {
                Console.WriteLine("Digite o valor para transferir:");
                if (double.TryParse(Console.ReadLine(), out double valorTransferencia))
                {
                    if (conta.Transferir(contaDestino, valorTransferencia))
                    {
                        Console.WriteLine("Transferência realizada com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível realizar a transferência.");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }
            }
            else
            {
                Console.WriteLine("Conta de destino não encontrada.");
            }
            break;
        case 4:
            return;
    }
    menuCaixa(conta);
}