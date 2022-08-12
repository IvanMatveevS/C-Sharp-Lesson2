Console.WriteLine("Введите целst 2 число ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if( x > 0)
{ 
    if (y > 0)
    {
        Console.WriteLine("1ая ");
    }
    else
    {
        Console.WriteLine("4ая ");
    }
}
else
{
    if (y > 0)
    {
        Console.WriteLine("2ая ");
    }
    else
    {
        Console.WriteLine("3ая ");
    }

}