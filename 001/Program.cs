// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double x=0;
double y=0;
int k1 = ReadInt("Введите k1= ");
int b1 = ReadInt("Введите b1= ");
int k2 = ReadInt("Введите k2= ");
int b2 = ReadInt("Введите b2= ");

if (k1==k2) 
{   if (b1==b2) Console.WriteLine("Прямые совпадают");
    else Console.WriteLine("Прямые паралельны, точек пересечения нет");

}
else 
{
x=(b2-b1)/(k1-k2);
y=k1*x+b1;
Console.WriteLine($"Прямые пересекаются при x={x} и у={y}");}
