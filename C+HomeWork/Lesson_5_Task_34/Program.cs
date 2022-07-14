/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
* [345, 897, 568, 234] -> 2 */
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(100, 1000); 
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count = count + 1;
    return count;
}
Console.Write("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(number);
PrintArray(array);
Console.WriteLine("Количество чётных чисел равно: " + FindEven(array));