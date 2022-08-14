Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int q = n;
int p = 0; 
int l = Convert.ToInt32(n % 10);
int k = Convert.ToInt32((n / 10000) % 10);
int j = Convert.ToInt32((n / 10) % 10);
int h = Convert.ToInt32((n / 1000) % 10);


while (q / 10 != 0)
{
    q = q / 10;
    p = p + 1;
}
int b = (p + 1);
if (b != 5)
{
    Console.WriteLine("Число не подходит!");
}
else
{
    if(l == k)
    {
        if(j == h)
        {
            Console.WriteLine("да");
        }
         else
        {
            Console.WriteLine("нет");
        }
    }
    else
    {
        Console.WriteLine("нет");
    }
}


/*Пока не знаю как это сделать !!!
int[] array = new int[5]; // определили массив из 5 элементов

FillArray(array); // метод заполняющий массив
array[0] = n % 10; // в массиве можно поставит значение на любое место принудительно
array[1] = n % 10;
array[2] = n % 10; 
array[3] = n % 10;
array[4] = n % 10; 
PrintArray(array); // распечатал массив 
Console.WriteLine();

if(array[0] = array[4])
{
   if(array[1] = array[3])
   {
    Console.WriteLine("Да");
   } 
   else
   {
    Console.WriteLine("Нет");
   }
}
else
{
    Console.WriteLine("Нет");
}
*/





