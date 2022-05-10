//Exercício-1
//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
//incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
//impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

Console.Write("Digite a senha: ");
int senha = int.Parse(Console.ReadLine());

while (senha != 2002)
{
    Console.WriteLine("Senha Inválida.");
    Console.Write("Digite a senha: ");
    senha = int.Parse(Console.ReadLine());

}

Console.WriteLine("Acesso Permitido");

Console.WriteLine("-----------------------------------------------------------------------------");
//Exercício-2
//Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
//cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
//menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

Console.Write("Digite a coordenada X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Digite a coordenada Y: ");
int y = int.Parse(Console.ReadLine());

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Primeiro Quadrante.");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Segundo Quadrante.");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Terceiro Quadrante.");
    }
    else
    {
        Console.WriteLine("Quarto Quadrante.");
    }

    Console.Write("Digite a coordenada X: ");
    x = int.Parse(Console.ReadLine());
    Console.Write("Digite a coordenada Y: ");
    y = int.Parse(Console.ReadLine());
}

Console.WriteLine("-----------------------------------------------------------------------------");
//Exercício-3
//Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
//um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
//4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
//que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
//mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
//exemplo.

Console.WriteLine("1.Álcool 2.Gasolina. 3.Diesel 4.Fim");
int alcool = 0;
int gasolina = 0;
int diesel = 0;
int codigo = int.Parse(Console.ReadLine());

while (codigo != 4)
{
    if (codigo == 1)
    {
        alcool = alcool + 1;
    }
    else if (codigo == 2)
    {
        gasolina = gasolina + 1;
    }
    else if (codigo == 3)
    {
        diesel = diesel + 1;
    }
    else
    {
        Console.WriteLine("Digite um novo código");

    }
    codigo = int.Parse(Console.ReadLine());
}

Console.WriteLine("Muito Obrigado!");
Console.WriteLine("Alcool: " + alcool);
Console.WriteLine("Gasolina: " + gasolina);
Console.WriteLine("Diesel: " + diesel);