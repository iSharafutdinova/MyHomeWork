/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] myArray = new int[4, 4];
int[,] CreateSpiralForm(int[,] array)
{
    int x = array.GetLength(1) - 1;
    int y = array.GetLength(0) - 1;
    int a = 0;
    int b = 0;
    int current = 1;
    int sum = array.GetLength(0) * array.GetLength(1);
        
    for (int j = 0; j < sum; j++)
    {
        for (int i = b; i < x; i++)
        {
            array[a, i] = current;
            current++;
            if (current > sum) return array;
        }
        for (int i = b; i < y; i++)
        {
            array[i, x] = current;
            current++;
            if (current > sum) return array;
        }
        for (int i = x; i > b; i--)
        {
            array[y, i] = current;
            current++;
            if (current > sum) return array;
        }
        for (int i = y; i > b; i--)
        {
            array[i, a] = current;
            current++;
            if (current > sum) return array;
        }
        if (current == sum)
        {
            array[array.GetLength(0) / 2, array.GetLength(1) / 2] = current;
            return array;
        }
        x--;
        y--;
        a++;
        b++;
    }
    return array;
}

Console.WriteLine();
Print2DArray(CreateSpiralForm(myArray));
Console.WriteLine();