﻿int a = new Random().Next(100, 1000);
Console.WriteLine(a);

int FirstDigit = a / 100;
int SecondDigit = a % 10;
Console.WriteLine(FirstDigit * 10 + SecondDigit);
