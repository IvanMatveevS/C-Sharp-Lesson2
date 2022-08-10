/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/
Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int p = 0;
int q = a;

while (q / 10 != 0)
{
    q = q / 10;
    p = p + 1;
}
int b = (p + 1);

if ( b >= 3)
{
    int i = Convert.ToInt32(Math.Pow(10, (b -3)));
    Console.WriteLine(((a / i) % 10));
}
else
{
    Console.WriteLine("Третьего числа нет");
}
