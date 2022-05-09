using System.Globalization;

//Exercícios Estrutura Condicional C#

//Exercício 1: Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

Console.Write("Digite um número inteiro: ");
int x = int.Parse(Console.ReadLine());

if (x < 0)
    Console.WriteLine("Este número é negativo.");

else
    Console.WriteLine("Este número não é negativo.");

Console.WriteLine("------------------------------------------------------------------------------------");

//Exercício 2: Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

Console.Write("Digite um número inteiro: ");
int y = int.Parse(Console.ReadLine());

if (y % 2 == 0)
    Console.WriteLine("Este número é par!");

else
    Console.WriteLine("Este número é ímpar!");

Console.WriteLine("------------------------------------------------------------------------------------");

//Exercício 3: Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
//Multiplos ", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
//ordem crescente ou decrescente.

Console.Write("Digite o primeiro número inteiro: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo número inteiro: ");
int B = int.Parse(Console.ReadLine());

if (A % B == 0 || B % A == 0)
    Console.WriteLine("São Multiplos.");
else
    Console.WriteLine("Não são multiplos.");

Console.WriteLine("------------------------------------------------------------------------------------");

//Exercício 4
//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
//começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

Console.Write("Hora incial do jogo: ");
int horaInicial = int.Parse(Console.ReadLine());
Console.Write("Hora final do jogo: ");
int horaFinal = int.Parse(Console.ReadLine());

int duracao;

if (horaInicial < horaFinal)
    duracao = horaFinal - horaInicial;
else
    duracao = 24 - horaInicial + horaFinal;

Console.WriteLine("Duração do jogo: " + duracao);

Console.WriteLine("------------------------------------------------------------------------------------");

//Exercício 5
//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
//seguir, calcule e mostre o valor da conta a pagar.

Console.Write("Digite o código e a quantidade dos itens a serem comprados: ");

string[] itens = Console.ReadLine().Split(' ');
int codigo = int.Parse(itens[0]);
int quantidade = int.Parse(itens[1]);
double total = 0;

if (codigo == 1)
{
    total = quantidade * 4.00;
}

else if (codigo == 2)
{
    total = quantidade * 4.50;
}

else if (codigo == 3)
{
    total = quantidade * 5.00;
}

else if (codigo == 4)
{
    total = quantidade * 2.00;
}

else if (codigo == 5)
{
    total = quantidade * 1.5;
}

Console.WriteLine("Valor a pagar R$: " + total.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine("------------------------------------------------------------------------------------");

//Exercício 6
//Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
//seguintes intervalos([0,25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
//nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

Console.Write("Digite um número: ");
double valor = double.Parse(Console.ReadLine());

if (valor > 0 && valor <= 25)
{
    Console.WriteLine("O valor se encontra no intervalo [0,25]");
}
else if (valor > 25 && valor <= 50)
{
    Console.WriteLine("O valor se encontra no intervalo [25,50]");
}
else if (valor > 50 && valor <= 75)
{
    Console.WriteLine("O valor se encontra no intervalo [50,75]");
}
else if (valor > 75 && valor <= 100)
{
    Console.WriteLine("O valor se encontra no intervalo [75,100]");
}
else
{
    Console.WriteLine("Fora de intervalo.");
}

Console.WriteLine("------------------------------------------------------------------------------------");

//Exercício 7
//Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
//de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
//ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
//Se o ponto estiver na origem, escreva a mensagem “Origem”.
//Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação

Console.Write("Digite os valores dos eixos X e Y: ");
string[] eixos = Console.ReadLine().Split(' ');
double eixoX = int.Parse(eixos[0]);
double eixoY = int.Parse(eixos[1]);

if (eixoX == 0 && eixoY == 0)
{
    Console.WriteLine("Origem.");
}
else if (eixoX == 0)
{
    Console.WriteLine("Eixo Y.");
}
else if (eixoY == 0)
{
    Console.WriteLine("Eixo X.");
}
else if (eixoX > 0 && eixoY > 0)
{
    Console.WriteLine("Q1.");
}
else if (eixoX < 0 && eixoY > 0)
{
    Console.WriteLine("Q2");
}
else if (eixoX < 0 && eixoY < 0)
{
    Console.WriteLine("Q3");
}
else
{
    Console.WriteLine("Q4");
}

Console.WriteLine("------------------------------------------------------------------------------------");

//Exercício 8
//Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
//mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
//Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
//salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
//de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
//duas casas decimais.

Console.Write("Digite o Salário: ");
double salario = double.Parse(Console.ReadLine());
double imposto;

if (salario <= 2000.0)
{
    imposto = 0;
}
else if (salario <= 3000.0)
{
    imposto = (salario - 2000.0) * 0.08;
}
else if (salario <= 4500.0)
{
    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
}
else
{
    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
}

if (imposto == 0.0)
{
    Console.WriteLine("Isento");
}
else
{
    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
}