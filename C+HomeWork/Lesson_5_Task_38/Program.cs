/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
* [3 7 22 2 78] -> 76 */
float[] CreateArray(int length)
{
    float[] array = new float[length];
    for(int i = 0; i < array.Length; i++) 
        array[i] = new Random().Next(0, 100); 
    return array;
}
void PrintArray(float[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
float FindMax(float[] array)
{
    float max = array[0];
    for(int i = 1; i < array.Length; i++)
        if(max < array[i]) max = array[i];
    return max;
}
float FindMin(float[] array)
{
    float min = array [0];
    for(int i = 0; i < array.Length; i++)
        if(min > array[i]) min = array[i];
    return min;
}
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length < 1) Console.Write("Ошибка! Длина массивы не может быть меньше 1");
float[] array = CreateArray(length);
PrintArray(array);
float result = FindMax(array) - FindMin(array);
Console.Write("Разница между максимальным и минимальным элементами равна: " + result);