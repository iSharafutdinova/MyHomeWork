/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
* 0, 7, 8, -2, -2 -> 2
* 1, -7, 567, 89, 223-> 3 */

void CreateArray(int[] array, int length)
{
    int index = 0;
    while (index < length) 
    {
        array[index] = new Random().Next(-10, 10);
        index++;
    }
}
void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}
void CountPositive(int[] array)
{
    int result = 0, index = 0;
    while (index < array.Length)
    {
        if (array[index] > 0) result++;
        index++;
    }
    Console.WriteLine(", количество положительных чисел равно: " + result);
}
Console.Write("Введите длину массива М: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
CreateArray(array, number);
PrintArray(array);
CountPositive(array);