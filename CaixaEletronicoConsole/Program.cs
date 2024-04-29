using CaixaEletronicoConsole;
using System.Collections.Specialized;
using System.Globalization;

string? burro;
CCorrente conta = new CCorrente("11234",500);
List<CCorrente> contas = new List<CCorrente>();
void menu()
{
    Console.WriteLine("-MENU-");
    Console.WriteLine("1. Acesso Administrativo");
    Console.WriteLine("2. Caixa Eletrônico");
    Console.WriteLine("3. Sair");
    int op = int.Parse(Console.ReadLine());
    switch(op)
    {
        case 1:
            menuAdm();
            break;
        case 2:
            menuCaixa();
            break;
        case 3:
            return;
            break;
    }
}

void menuAdm()
{
    Console.WriteLine("-MENU-");
    Console.WriteLine("1. Cadastro de Conta Corrente");
    Console.WriteLine("2. Mostrar os Saldos");
    Console.WriteLine("3. Excluir Conta");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            menuAdm();
            break;
        case 2:
            menuCaixa();
            break;
        case 3:
            return;
            break;
    }
}

void menuCaixa()
{
    Console.Write("Qual é a sua conta: ");
    bool find;
    string testAcc = Console.ReadLine();
    foreach
    if (CCorrente.(testAcc).status == true)
    {
        Console.WriteLine("-MENU-");
        Console.WriteLine("1. Saque");
        Console.WriteLine("2. Depósito");
        Console.WriteLine("3. Transferência");
        Console.WriteLine("4. Voltar");
        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                menuAdm();
                break;
            case 2:

                break;
            case 3:
                menu();
                break;
        }
    }
}
