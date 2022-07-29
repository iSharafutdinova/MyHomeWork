/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumNumsInInterval(int M, int N)
{
    if (N > M) return N + SumNumsInInterval(M, N - 1);
    return N;
}

Console.Write("Введите число M (начало исследуемого интервала): ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N (конец исследуемого интервала): ");
int N = Convert.ToInt32(Console.ReadLine());

if (M != N) Console.WriteLine("Сумма натуральных чисел в промежутке от M до N равна: " + SumNumsInInterval(M, N));
else
    Console.WriteLine("Ошибка! Числа M и N не должны быть равными!");