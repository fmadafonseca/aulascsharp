//Exercícicos de Estrutura Repetitiva For

//Exercício-1
//Leia um valor inteiro Z (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até o valor Z, um valor por linha, inclusive o 
//Z, se for o caso

int z;
z = int.Parse(Console.ReadLine());

int impar = 0;
for (int i = 1; i <= z; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }

}

Console.WriteLine("------------------------------------------------------------------------------------------");
//Exercício-2
//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
//Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
//essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)

int N;
N = int.Parse(Console.ReadLine());

int dentro = 0;
int fora = 0;

for (int i = 1; i <= N; i++)
{
    if (i >= 10 && i <= 20)
    {
        dentro ++;
    }
    else
    {
        fora ++;
    }
}
Console.WriteLine(dentro + " in");
Console.WriteLine(fora + " fora");

Console.WriteLine("------------------------------------------------------------------------------------------");
//Exercício-3
//Leia 1 valor inteiro Y, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
//de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
//conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
//peso 5

Console.Write("Quantos testes serão executados? ");
int Y = int.Parse((Console.ReadLine()));

for (int i = 1; i <= Y; i++)
{
    double a = double.Parse((Console.ReadLine()));
    double b = double.Parse((Console.ReadLine()));
    double c = double.Parse((Console.ReadLine()));
    double media = ((a * 2) + (b * 2) + (c * 5)) / 10;
    Console.WriteLine("Média: " + media);
}
Console.WriteLine("------------------------------------------------------------------------------------------");
//Exercício-4
//Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
//segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

Console.Write("Número de Pares: ");
int pares = int.Parse(Console.ReadLine());

for (int i = 1; i <= pares; i++)
{
    string [] a = Console.ReadLine().Split(' ');
    int x = int.Parse(a[0]);
    int y = int.Parse(a[1]);
    
    if (y == 0)
    {
        Console.WriteLine("divisão impossível");
    }
    else
    {
        Console.WriteLine(x / y);
    }
}
Console.WriteLine("------------------------------------------------------------------------------------------");
//Exercício-5
//Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) *(N - 2) * (N - 3) * ... *1.
//Lembrando que, por definição, fatorial de 0 é 1.

int numero = int.Parse(Console.ReadLine());


int fatorial = 1;
for (int i = 1; i <= numero; i++)
{
    fatorial = fatorial * i;
}

Console.WriteLine(fatorial);

Console.WriteLine("------------------------------------------------------------------------------------------");
//Exercício-6
//Ler um número inteiro N e calcular todos os seus divisores.

Console.Write("Digite o número: ");
int num = int.Parse((Console.ReadLine()));

for(int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine("------------------------------------------------------------------------------------------");
//Exercício-7
//Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
//começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
//exemplo.

int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{

    int primeiro = i;
    int segundo = i * i;
    int terceiro = i * i * i;
    Console.WriteLine($"{primeiro} {segundo} {terceiro}");
}
