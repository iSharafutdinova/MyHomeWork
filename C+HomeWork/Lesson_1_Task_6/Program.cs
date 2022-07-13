// Задача 6. Программа, которая на вход принимает число и выдаёт, является ли число чётным
int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num%2 == 0)
{
    Console.Write("Число чётное");
}
else
{
    Console.Write("Число нечётное");
}