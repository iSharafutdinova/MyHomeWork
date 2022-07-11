/* Задача 15. Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

void WeekEnd(int number)
{
    if (number > 7) Console.WriteLine("Дня под указанным номером не существует - в неделе всего 7 дней");
    else if (number < 1) Console.WriteLine("Ошибка: введено отрицательное число");
    else if (number < 6) Console.WriteLine("День под соответствующим номером не является выходным");
    else if (number > 5) Console.WriteLine("Ура! День под соответствующим номером - выходной");    
}
int num;
Console.Write("Введите число от 1 до 7: ");
num = Convert.ToInt32(Console.ReadLine());
WeekEnd(num);