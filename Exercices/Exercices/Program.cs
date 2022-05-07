using System.Globalization;

//exercício 1
//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa.

Console.WriteLine("Digite o primeiro número inteiro: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo Número inteiro: ");
int n2 = int.Parse(Console.ReadLine());

int soma = n1 + n2;
Console.WriteLine("A soma dos dois números é: " + soma);

Console.WriteLine("---------------------------------------");
//exercício 2
//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
//casas decimais.

double r, A;
double pi = 3.14159;

Console.WriteLine("Informe o raio do círculo: ");
r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

A = pi * (Math.Pow(r, 2));

Console.WriteLine($"A área do círculo é: {A.ToString("F4", CultureInfo.InvariantCulture)}");

Console.WriteLine("---------------------------------------");
//exercício 3
//Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
//de A e B pelo produto de C e D.

int X, W, Y, Z, resultado;

Console.WriteLine("Digite o primeiro número inteiro: ");
X = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número inteiro: ");
W = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro número inteiro: ");
Y = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o quarto número inteiro: ");
Z = int.Parse(Console.ReadLine());

resultado = X * W - Y * Z;
Console.WriteLine("A diferença do produto entre A e B pelo produto de C e D é de: " + resultado);

Console.WriteLine("---------------------------------------");
//exercícios 4
//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
//hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
//decimais.

int matricula;
double valorHora, salario;
double horas;

Console.WriteLine("Matrícula do funcionário: ");
matricula = int.Parse(Console.ReadLine());
Console.WriteLine("Valor recebido por hora do funcionário: ");
valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
Console.WriteLine("Horas trabalhadas pelo funcionário: ");
horas = int.Parse(Console.ReadLine());

salario = valorHora * horas;

Console.WriteLine("Matrícula: " + matricula);
Console.WriteLine("Salário: R$" + salario.ToString("F2"));

Console.WriteLine("---------------------------------------");
//exercício 5
//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
//código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

int codPeca1, codPeca2, numPecas1, numPecas2;
double valorPeca1, valorPeca2, valorTotal;

Console.WriteLine("Digite o código da peça 1: ");
codPeca1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da peça 1: ");
valorPeca1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
Console.WriteLine("Digite o número de peças 1 a serem compradas: " );
numPecas1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o código da peça 2: ");
codPeca2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da peça 2: ");
valorPeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Digite o número de peças 2 a serem compradas: ");
numPecas2 = int.Parse(Console.ReadLine());

valorTotal = (numPecas1 * valorPeca1) + (numPecas2 * valorPeca2);
Console.WriteLine("Valor a pagar: R$" + valorTotal);

Console.WriteLine("---------------------------------------");
//Fazer um programa que leia três valores com ponto flutuante de dupla precisão: D, E e F. Em seguida, calcule e
//mostre:
//a) a área do triângulo retângulo que tem D por base e F por altura.
//b) a área do círculo de raio F. (pi = 3.14159)
//c) a área do trapézio que tem D e E por bases e F por altura.
//d) a área do quadrado que tem lado E.
//e) a área do retângulo que tem lados D e E.

double D, E, F, triangulo, circulo, trapezio, quadrado, retangulo;

Console.WriteLine("Digite três valores: ");
string [] valores = Console.ReadLine().Split(' ');
D = double.Parse(valores[0], CultureInfo.InvariantCulture);
E = double.Parse(valores[1], CultureInfo.InvariantCulture);
F = double.Parse(valores[2], CultureInfo.InvariantCulture);

triangulo = D * F / 2;
circulo = pi * (Math.Pow(F, 2));
trapezio = (D + E) * F / 2;
quadrado = (Math.Pow(E, 2));
retangulo = D * E;

Console.WriteLine("Área do triângulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Área do círculo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Área do trapézio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Área do quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("Área do retângulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));


Console.WriteLine("Fim dos exercícios");










