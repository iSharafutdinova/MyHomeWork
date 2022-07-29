/* Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"} */

string[] CreateStringArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите слово для массива " + (i + 1) + ": ");
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

string[] СoncatenationArray (string[] arrayFirst, string[] arraySecond) {
    int lengthFirst = arrayFirst.Length;
    string[] newArray = new string[lengthFirst];
    for (int i = 0; i < lengthFirst; i++)
    {
        newArray[i] = arrayFirst[i] + arraySecond[i];
    }
    return newArray;
}

Console.Write("Введите номер числа для двух массивов: ");
int N = Convert.ToInt32(Console.ReadLine());

string[] myFirstArray = CreateStringArray(N);

string[] mySecondArray = CreateStringArray(N);

PrintArray(myFirstArray);
PrintArray(mySecondArray);

string[] resultArray = СoncatenationArray(myFirstArray, mySecondArray);

PrintArray(resultArray);