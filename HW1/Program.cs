int a = new Random().Next(100, 1000);
Console.WriteLine(a);

int SecondDigit = a / 10;
int chek = SecondDigit % 10;
Console.WriteLine(chek);
