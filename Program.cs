/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите число a:");
int first = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b:");
int second = int.Parse(Console.ReadLine()!);
if (first > second)
{
    Console.WriteLine($"max={first}");
}
else
{
    Console.WriteLine($"max={second}");
}
/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите число a:");
int first = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b:");
int second = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число c:");
int third = int.Parse(Console.ReadLine()!);
int max=first;
if (second>max) max=second;
if (third>max) max=third;
Console.WriteLine ($"Max={max}");