// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

if (number2 > number1)
{
    Console.Write($"Число {number1} - меньшее, число {number2} - большее");
}
else
{
    Console.Write($"Число {number1} - большее, число {number2} - меньшее");
}