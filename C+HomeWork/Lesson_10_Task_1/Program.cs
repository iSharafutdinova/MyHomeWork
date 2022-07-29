/* Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1 */

string[] CreateStringArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите слово №" + (i + 1) + ": ");
        string newArray = Convert.ToString(Console.ReadLine());
        array[i] = newArray;
    }
    return array;
}

void PrintArray(string[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

int CountWords(string[] array)
{
    int length = array.Length;
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i][0] == vowels[0] || array[i][0] == vowels[1] || array[i][0] == vowels[2] || array[i][0] == vowels[3] || array[i][0] == vowels[4] || array[i][0] == vowels[5])
        {
            count++;
        }
    }
    return count;
}

Console.Write("Задайте размер массива (сколько слов будет всего): ");
int N = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateStringArray(N);

PrintArray(myArray);

Console.WriteLine("Количество слов в массиве, начинающихся на глаcную букву: " + CountWords(myArray));