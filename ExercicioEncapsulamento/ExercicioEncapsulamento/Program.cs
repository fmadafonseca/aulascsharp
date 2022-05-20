using System.Globalization;
namespace ExercicioEncapsulamento;

class program
{
    static void Main(String[] args)
    {
        Conta conta1;

        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial(s/n)? ");
        char resposta = char.Parse(Console.ReadLine());

        Conta Conta1 = new Conta(numero, titular, 0);

        if (resposta == 's' || resposta == 'S')
        {
            Console.Write("Entre o valor do depósito inicial: " );
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1 = new Conta(numero, titular, depositoInicial);
        }
        else
        {
            conta1 = new Conta(numero, titular);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta: " + conta1);

        Console.WriteLine();
        Console.Write("Entre um valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta1.Deposito(deposito);
        Console.WriteLine("Dados da conta atualizados: " + conta1);

        Console.WriteLine();
        Console.Write("Entre um valor para saque: ");
        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta1.Saque(saque);
        Console.WriteLine("Dados da conta atualizados: " + conta1);

























    }






























}