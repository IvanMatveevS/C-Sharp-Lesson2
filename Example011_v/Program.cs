void FillArray(int[] collection) // void - метод ничего не возвращает 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);      
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;

    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    

    while(index < count)

    {
        if(collection[index] == find)
        {
             position = index;
             break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // определили массив из 10 элементов

FillArray(array); // метод заполняющий массив
array[4] = 4; // в массиве можно поставит значение на любое место принудительно
array[9] = 4;
PrintArray(array); // распечатал массив 
Console.WriteLine();

int pos = IndexOf(array,444);
Console.WriteLine(pos);