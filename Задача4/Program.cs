//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число ");
int number = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число ");
int number2 = int.Parse(Console.ReadLine()!);
int max = number;

if(number1 > max)
{
    max = number1;
}

if(number2 > max)
{
    max = number2;
}
Console.WriteLine($"Максимальное число {max}");

