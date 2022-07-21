/* Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

double[,] Create2DArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 10);
    return array;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int MinSummLine(double[,] array)
{
    double temp;
    double temp2 = 0;
    int minline = 0;
    for (int j = 0; j < array.GetLength(1); j++) //сумма элементов первой строки, отправная точка
        temp2 += array[0, j];
    Console.WriteLine(temp2);
    for (int i = 1; i < array.GetLength(0); i++) //сравнение суммы первой строки с остальными строками и поиск наименьшей
    {
        temp = 0;
        for (int j = 0; j < array.GetLength(1); j++) //вычисление суммы элементов строки
            temp += array[i, j];
        Console.WriteLine(temp);
        if (temp < temp2)
        {
            minline = i; //запоминание строки с минимальной суммой
            temp2 = temp; //запоминание минимального числа для последующего сравнения
        }
    }
    return minline + 1;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] myArray = Create2DArray(rows, columns);
Print2DArray(myArray);
Console.WriteLine();
double result = MinSummLine(myArray);
Console.WriteLine("Минимальная сумма элементов в строке номер " + result);