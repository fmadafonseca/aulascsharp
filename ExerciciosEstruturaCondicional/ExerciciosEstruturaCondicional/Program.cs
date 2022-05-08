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

Console.WriteLine("------------------------------------------------------------------------------------");

//Exercício 5
//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
//seguir, calcule e mostre o valor da conta a pagar.

