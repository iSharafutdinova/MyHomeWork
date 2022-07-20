/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] Create2DArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for(int i=0; i < rows; i++)
        for(int j=0; j < columns; j++)
            newArray[i,j] = new Random().Next(1, 10);
    
    return newArray;
}

void Print2DArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void CountAverageInColumns(int[,] array)
{
    int num = 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;

        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double average = sum / array.GetLength(0);
        Console.Write(Math.Round(average, 1) + "  ");
        num++;
    }
}

Console.Write("Введите число строк для создания двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов для создания двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns);
Print2DArray(myArray);
CountAverageInColumns(myArray);