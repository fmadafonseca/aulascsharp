using System.Globalization;
//Exercício-1
//Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
//velha.

namespace exerciciosPOO;

class Program
{
    static void Main(String[] args)
    {
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();

        Console.WriteLine("Dados da primeira pessoa:");
        Console.Write("Nome: ");
        p1.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        p1.Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Dados da segunda pessoa:");
        Console.Write("Nome: ");
        p2.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        p2.Idade = int.Parse(Console.ReadLine());

        if (p1.Idade > p2.Idade)
        {
            Console.WriteLine("Pessoa mais velha: " + p1.Nome);
        }
        else
        {
            Console.WriteLine("Pessoa mais velha: " + p2.Nome);
        }


        Console.WriteLine("-----------------------------------------------------------------");
        //exercício-2
        //Fazer um programa para ler nome e salário de dois funcionários.Depois, mostrar o salário
        //médio dos funcionários.
        Funcionario f1 = new Funcionario();
        Funcionario f2 = new Funcionario();

        Console.WriteLine("Dados do primeiro funcionário:");
        Console.Write("Nome: ");
        f1.Nome = Console.ReadLine();
        Console.Write("Salário: ");
        f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Dados do segundo funcionário:");
        Console.Write("Nome: ");
        f2.Nome = Console.ReadLine();
        Console.Write("Salário: ");
        f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = (f1.Salario + f2.Salario) / 2;
        Console.Write("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));




    }
}