/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
// AC^2 = AD^2 + DC^2
// AB^2 = AC^2 + BC^2 = AD^2 + DC^2 + BC^2

double Length3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double l1 = x2 - x1;
    double l2 = y2 - y1;
    double l3 = z2 - z1;
    double l = Math.Sqrt(l1*l1 + l2*l2 + l3*l3);
    return l;
}
Console.Write("Введите координату Х первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Длина отрезка равна " + Math.Round(Length3D(x1, y1, z1, x2, y2, z2),2));