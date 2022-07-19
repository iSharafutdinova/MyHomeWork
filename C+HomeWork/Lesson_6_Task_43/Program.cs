/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
* b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */

void CreateArray(double[] array)
{
    for (int index = 0; index < array.Length; index++) 
    {
        Console.Write(array[index] + " ");
    }
    Console.WriteLine();        
}

double[] Find(double x1, double y1, double x2, double y2)
{
    double[] Point = {0, 0};
    if (y1 == y2)
    {
        Point[0] = (x2 - x1) / (y2 - y1);
        Point[1] = y1 * Point[0] + x1;
    }
    return Point;
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Координаты точки пересечения двух прямых: ");
CreateArray(Math.Round(Find(b1, k1, b2, k2),2));