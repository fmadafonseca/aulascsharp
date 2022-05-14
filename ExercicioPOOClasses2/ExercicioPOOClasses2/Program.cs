﻿using System.Globalization;

namespace ExercicioPOOClasses2;

class Program
{
    static void Main(string[] args)
    {

        Funcionario func = new Funcionario();
        double porcentagem;

        Console.Write("Nome: ");
        func.Nome = Console.ReadLine();
        Console.Write("Salário bruto: ");
        func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Funcionário: "+ func);

        Console.WriteLine();
        Console.Write("Digite a porcentagem para aumentar o salário: ");
        porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        func.AumentarSalario(porcentagem);

        Console.WriteLine();
        Console.Write("Dados Atualizados: " + func);
    }
}