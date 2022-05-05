//Conversão implícita
float productPrice1 = 5.75F;
double productPrice2 = productPrice1;

Console.WriteLine(productPrice2);

//Conversão explícita(casting)
double measure1;
float measure2;

measure1 = 1.70;
measure2 = (float)measure1;

Console.WriteLine(measure2);

//conversão explícita(casting) com perda de dados
float pi1 = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446F;
int pi2 = (int)pi1;
Console.WriteLine(pi1);
Console.WriteLine(pi2);
