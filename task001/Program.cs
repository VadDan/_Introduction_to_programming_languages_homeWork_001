﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
{
    int maxNum = numA;
    int minNum = numB;
    Console.Write("max: ");
    Console.WriteLine(maxNum);
    Console.Write("min: ");
    Console.WriteLine(minNum);
}
else
{
    int maxNum = numB;
    int minNum = numA;
    Console.Write("max: ");
    Console.WriteLine(maxNum);
    Console.Write("min: ");
    Console.WriteLine(minNum);
}