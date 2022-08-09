int a = new Random().Next(10, 100); //рандомное число из интервала от 10 до 100

Console.WriteLine(a);

int FirstDigit = a / 10;
int SecondDigit = a % 10;

if (FirstDigit > SecondDigit)
{
    Console.WriteLine("Наибольшая цифра" + FirstDigit);
}
else
{
     Console.WriteLine("Наибольшая цифра" + SecondDigit);
}
