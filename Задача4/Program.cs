// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите первое число");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите первое число");
int number3 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.Write($"Максимальное число {number1}");
    }
    else
    {
        Console.Write($"Максимальное число {number3}");
    }
}
else
{
    if (number2 > number3)
    {
        Console.Write($"Максимальное число {number2}");
    }
    else
    {
        Console.Write($"Максимальное число {number3}");
    }
}