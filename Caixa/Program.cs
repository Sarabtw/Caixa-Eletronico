using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Conta conta1 = new Conta("João", "Corrente");
        Conta conta2 = new Conta("Maria", "Poupança");

        bool sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao Caixa Eletrônico!");
            Console.WriteLine("1. Saque");
            Console.WriteLine("2. Depósito");
            Console.WriteLine("3. Extrato");
            Console.WriteLine("4. Transferência");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha um tipo de serviço descrito acima: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o número da conta: (Ex: Número da conta: 12340)");
                    int conta = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o número da agência: (Ex: Agência: 1234567)");
                    int agencia = int.Parse(Console.ReadLine());

                    Console.Write("Qual valor você deseja sacar? ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta1.Sacar(valorSaque);

                    Console.WriteLine("Confirme o saque com senha: ");
                    int senha = int.Parse(Console.ReadLine());

                    break;
                case 2:
                    Console.WriteLine("Digite o número da conta: (Ex: Número da conta: 12340)");
                    conta = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o número da agência: (Ex: Agência: 1234567)");
                     agencia = int.Parse(Console.ReadLine());

                    Console.Write("Qual valor você deseja depositar? ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta1.Depositar(valorDeposito);

                    Console.WriteLine("Confirme o deposito com senha: ");
                     senha = int.Parse(Console.ReadLine());
                    break;

                case 3:
                    conta1.ExibirExtrato();
                    conta1.SalvarExtratoEmArquivo();

                    Console.WriteLine("Digite o número da conta: (Ex: Número da conta: 12340)");
                    conta = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o número da agência: (Ex: Agência: 1234567)");
                     agencia = int.Parse(Console.ReadLine());

                    Console.WriteLine("Confirme a ação com senha: ");
                    senha = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Digite o número da conta: (Ex: Número da conta: 12340)");
                     conta = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o número da agência: (Ex: Agência: 1234567)");
                    agencia = int.Parse(Console.ReadLine());

                    Console.Write("Informe o valor da transferência: ");
                    double valorTransferencia = double.Parse(Console.ReadLine());
                    conta1.Transferir(conta2, valorTransferencia);

                    Console.WriteLine("Confirme a transferência com senha: ");
                     senha = int.Parse(Console.ReadLine());
                    break;
                case 5:
                    sair = true;
                    Console.WriteLine("Obrigado pela preferência, volte sempre! ");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

           
            
        }
    }
}

class Conta
{
    private string titular;
    private string tipoConta;
    private double saldo;

    public Conta(string titular, string tipoConta)
    {
        this.titular = titular;
        this.tipoConta = tipoConta;
        this.saldo = 0;
    }

    public void Sacar(double valor)
    {
        if (valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else if (valor <= 0)
        {
            Console.WriteLine("Valor inválido.");
        }
        else
        {
            saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
        }
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor inválido.");
        }
        else
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
        }
    }

    public void ExibirExtrato()
    {
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Tipo de Conta: {tipoConta}");
        Console.WriteLine($"Saldo Atual: {saldo:C}");
    }

    public void Transferir(Conta destino, double valor)
    {
        if (valor > saldo)
        {
            Console.WriteLine("Saldo insuficiente para transferência.");
        }
        else if (valor <= 0)
        {
            Console.WriteLine("Valor inválido.");
        }
        else
        {
            saldo -= valor;
            destino.Depositar(valor);
            Console.WriteLine($"Transferência de {valor:C} para {destino.titular} realizada com sucesso.");
        }
    }

    public void SalvarExtratoEmArquivo()
    {
        string nomeArquivo = $"{titular}_extrato.txt";
        using (StreamWriter writer = new StreamWriter(nomeArquivo))
        {
            writer.WriteLine($"Titular: {titular}");
            writer.WriteLine($"Tipo de Conta: {tipoConta}");
            writer.WriteLine($"Saldo Atual: {saldo:C}");
        }
        Console.WriteLine($"Extrato salvo em arquivo: {nomeArquivo}");
    }
}  