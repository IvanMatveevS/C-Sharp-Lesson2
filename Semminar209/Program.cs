Console.WriteLine("Введите координаты первой точки");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
Console.WriteLine(AB);
