
/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите число a:");
int first = int.Parse(Console.ReadLine()!);
if (first %2==0)
{
    Console .WriteLine ($"Число {first} четное");
}
else
{
    Console .WriteLine ($"Число {first} не четное");
}
