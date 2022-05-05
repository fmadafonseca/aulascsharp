// Operadores aritméticos
int n1 = 30 + 20 - 10 + 20;
int n2 = n1 * 2;
int n3 = n2 / 12;
int n4 = (n3 + 1) % 3;
int n5 = n4 * 30;

Console.WriteLine(n5);


Console.WriteLine();
// Fórmula de Bhaskara

double a = 1.0, b = -3.0, c = -4.0;

double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

Console.WriteLine(delta);
Console.WriteLine(x1);
Console.WriteLine(x2);