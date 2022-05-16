using System.Globalization;
/*Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais. Informar quantos reais a pessoa vai
pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversordeMoeda
para ser responsável pelos cálculos*/
namespace ExercicioMembrosEstaticos;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe a cotação atual do dólar: ");
        double valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Informe quantos dólares você vai comprar: ");
        double qtdeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double total = ConversorDeMoedas.Conversao(valorDolar, qtdeDolar);

        Console.WriteLine("Valor a ser pago em reais: " + total.ToString("F2", CultureInfo.InvariantCulture));

    }
}