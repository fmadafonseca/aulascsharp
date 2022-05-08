Console.WriteLine("Entre com um número inteiro: ");
int x = int.Parse(Console.ReadLine());

if (x % 2 == 0)

    Console.WriteLine("Este número é par!");

else

    Console.WriteLine("Este número é ímpar");


Console.WriteLine("-------------------------------------------------");

Console.WriteLine("Digite a hora atual: ");
int hora = int.Parse(Console.ReadLine());

if (hora < 12)

    Console.WriteLine("Bom dia!");

else if (hora > 12 && hora < 18)

    Console.WriteLine("Boa tarde!");


else

    Console.WriteLine("Boa noite!");


