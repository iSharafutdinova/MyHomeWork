/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

void Palindrom (string number)
{
    if (number.Length > 5) Console.Write("Ошибка! Введите пятизначное число");
    else 
    {
        if (number[0]==number[4] || number[1]==number[3])
        Console.Write("Заданное число является палиндромом");
        else Console.Write("Заданное число не является палиндромом");
    }
}
Console.Write("Введите число: ");
string N = Console.ReadLine();
Palindrom(N);