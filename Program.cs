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