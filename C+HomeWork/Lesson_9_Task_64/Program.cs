/* Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
N = 4532 -> 4 */

int CountDigitsInNumber(int number)
{
    if (number / 10 != 0) return 1 + CountDigitsInNumber(number / 10);
    else return 1;
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество цифр в заданном числе: " + CountDigitsInNumber(N));