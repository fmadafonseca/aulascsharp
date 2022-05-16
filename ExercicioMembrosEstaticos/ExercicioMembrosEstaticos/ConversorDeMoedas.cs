
namespace ExercicioMembrosEstaticos;

internal class ConversorDeMoedas
{
    public static double Iof = 6.0;
    public static double Conversao(double valorDolar, double qtdeDolar)
    {
        double total = ((valorDolar * qtdeDolar) + (valorDolar * qtdeDolar)) * Iof / 100;
        return total + valorDolar * qtdeDolar;
    }
}
