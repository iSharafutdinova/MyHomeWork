/* Задача 10. Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int FindSecondDigit(int number)
{
    int attempt = number/10;
    int result = attempt%10;
    return result;
}
int num;
Console.Write("Введите трёхзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num < 100) Console.Write("Ошибка! Необходимо ввести трёхзначное число");
else if (num > 999) Console.Write("Ошибка! Необходимо ввести трёхзначное число");
else Console.Write("Второй цифрой является цифра: " + FindSecondDigit(num));