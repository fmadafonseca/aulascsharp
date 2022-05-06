using System.Globalization;

Console.WriteLine("Type your full name: ");
string fullName = Console.ReadLine();

Console.WriteLine("How many bedrooms do you have?");
int bedrooms = int.Parse(Console.ReadLine());

Console.WriteLine("Type the price of a product: ");
double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Type your last name age and height(same line)");
string[] vet = Console.ReadLine().Split(' ');
string v1 = vet[0];
int v2 = int.Parse(vet[1]);
double v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine(fullName);
Console.WriteLine(bedrooms + "bedrooms");
Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine($"{v1} {v2} {v3.ToString("F2", CultureInfo.InvariantCulture)}");