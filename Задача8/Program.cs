// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число от 0: ");
int number = int.Parse(Console.ReadLine());
int number2 = 1;

while (number2 <= number)
    {
        if (number2 % 2 == 0)
        {
            Console.Write(number2+" ");
            number2++;
        }
        else
        {
            number2++;
        }
    } 
    