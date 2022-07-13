/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
* 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
* 6, 1, 33 -> [6, 1, 33]
*/

/*Для массива из случайных чисел от 1 до 9: 
void CreateArray(int[] array, int length)
{
    int index = 0;
    while (index < length) 
    {
        array[index] = new Random().Next(1, 10);
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
Console.Write("Введите длину массива (не больше восьми): ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
if (number > 8) Console.Write("Ошибка! Длина массива не может быть больше восьми");
else{
    CreateArray(array, number);
    PrintArray(array);
    }
*/

/*
Console.Write("Введите первое число для массива: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для массива: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число для массива: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите четвертое число для массива: ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите пятое число для массива: ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите шестое число для массива: ");
int n6 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите седьмое число для массива: ");
int n7 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите восьмое число для массива: ");
int n8 = Convert.ToInt32(Console.ReadLine());
int[] array = {n1, n2, n3, n4, n5, n6, n7, n8};
Console.Write("Задан массив {" + n1 + ", " + n2 + ", " + n3 + ", " + n4 + ", " + n5 + ", " + n6 + ", " + n7 + ", " + n8 + "}");
*/