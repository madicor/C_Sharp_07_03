﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

int num1 = 0;
int num2 = 0;

Console.Write("Please enter number1 n1 = ");
num1 = int.Parse(Console.ReadLine()!);

Console.Write("Please enter number2 n2 = ");
num2 = int.Parse(Console.ReadLine()!);

if ((num2 * num2) == num1)
{
  Console.WriteLine("yes!");
}
else
{
  Console.WriteLine("no!");
}