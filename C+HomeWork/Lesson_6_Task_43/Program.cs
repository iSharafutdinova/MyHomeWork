/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
* b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) 

y = k1 * x + b1
y = k2 * x + b2
k1 * x + b1 = k2 * x + b2
x * (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)
*/

double FindX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return y;
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2) Console.WriteLine("Пересечения не найдено. Прямые параллельны!");
else {
    double x = FindX(b1, k1, b2, k2);
    double y = FindY(b1, k1, b2, k2);
    Console.WriteLine("Координаты точки на плоскости: (" + x + "; " + y + ")");
}