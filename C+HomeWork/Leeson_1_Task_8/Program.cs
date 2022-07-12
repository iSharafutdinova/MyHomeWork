// Задача 8. Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N;
Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());
int current = 2;

while (current <= N)
{
    Console.Write(current + " ");
    current = current + 2;
}