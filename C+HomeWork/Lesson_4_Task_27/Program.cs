/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
* 452 -> 11
* 82 -> 10
* 9012 -> 12 */
void DigitSum (int number)
{
    int current = 0, result = 0;
    while (number > 0)
    {
        current = number%10; 
        number = number/10;
        result = result + current;
    }
    Console.WriteLine("Сумма цифр заданного числа равна: " + result);
}
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
DigitSum(N);