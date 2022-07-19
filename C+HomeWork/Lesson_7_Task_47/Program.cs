/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
-3,3 8 -9,9
7,8 -7,1 9 */

double[,] CreateRandom2DArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];

    for(int i=0; i < rows; i++)
        for(int j=0; j < columns; j++)
            newArray[i,j] = new Random().NextDouble();    
    return newArray;
}

void Show2DArray(double[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j], 1) + " ");
        
        Console.WriteLine();
    }
}

Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2DArray(rows, columns);
Show2DArray(myArray);