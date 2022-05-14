﻿using System.Globalization;

namespace ExercicioPOOClasses3;
class Program
{
    static void Main(string[] args)
    {

        Aluno aluno = new Aluno();

        Console.Write("Nome do aluno: ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Digite as três notas do alunos: ");
        aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Nota final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
        if (aluno.Aprovado())
        {
            Console.WriteLine("Aprovado!");
        }
        else
        {
            Console.WriteLine("Reprovado");
            Console.WriteLine("Faltaram "
            + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
            + " pontos");

        }
    }
}
