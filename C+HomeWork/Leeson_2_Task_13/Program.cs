/* Задача 13. Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

void FindThirdChar(string number)
{
    if (number.Length < 3) Console.Write("Третьей цифры нет");
    if (number.Length >= 3) 
    {
        char ThirdChar = number[2]; 
        Console.Write("Третья цифра заданного числа - это цифра " + ThirdChar);
    }
}
Console.Write("Введите число: ");
var num = Console.ReadLine();
FindThirdChar(num); 
*/