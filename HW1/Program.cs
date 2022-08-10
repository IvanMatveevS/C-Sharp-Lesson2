Console.WriteLine("Введите число от 100 до 999: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Второе число: ");
int SecondDigit = a / 10;
int chek = SecondDigit % 10;
Console.WriteLine(chek);
