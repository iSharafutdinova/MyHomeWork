/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет */

int[,] Create2DArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for(int i=0; i < rows; i++)
        for(int j=0; j < columns; j++)
            newArray[i,j] = new Random().Next(1, 10);
    
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

int FindArrayElement(int[,] array, int row, int column)
{
    if (row > array.GetLength(0) || column > array.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
        return -1;
    }
    return array[row - 1, column - 1];
}

Console.Write("Введите число строк для создания двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов для создания двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns);
Show2DArray(myArray);

Console.Write("Введите номер строки для искомого элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца для искомого элемента: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write(FindArrayElement(myArray, row, col));