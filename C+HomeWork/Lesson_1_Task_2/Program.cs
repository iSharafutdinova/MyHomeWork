// Задача 2. Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
int n1, n2;
Console.Write("Введите первое число: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
n2 = Convert.ToInt32(Console.ReadLine());
if(n1==n2)
{
    Console.Write("Числа равны");
}
else
{
    if(n1 > n2)
{
    Console.Write("Большее число: " + n1 + ". Меньшее число: " + n2);
}
else 
{
    Console.Write("Большее число: " + n2 + ". Меньшее число: " + n1);
}
}