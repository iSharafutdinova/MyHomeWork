// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
int n1, n2, n3, max;
Console.Write("Введите первое число: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
n3 = Convert.ToInt32(Console.ReadLine());
max = n1;
if(n2 > max) max = n2;
if(n3 > max) max = n3;
Console.Write("Максимальным числом является: " + max);