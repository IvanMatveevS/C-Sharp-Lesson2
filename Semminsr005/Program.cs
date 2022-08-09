int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if( a / b == b ^ b / a == a)
{
    Console.WriteLine("да");
    
}
else 
{
    Console.WriteLine( "нет " );
}