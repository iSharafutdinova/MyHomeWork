/* Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
* [3, 7, 23, 12] -> 19
* [-4, -6, 89, 6] -> 0 */
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(1, 100); 
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int OddSum (int[] array)
{
    int sum = 0;
    
    for(int i = 0; i < array.Length; i++)
        if (i % 2 != 0) sum += array[i];
    return sum;
}
Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(n);
PrintArray(array);
Console.WriteLine("Сумма нечётных элементов массива равна: " + OddSum(array));