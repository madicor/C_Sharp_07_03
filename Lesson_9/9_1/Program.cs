﻿//  Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8" 

int start = GetUserNumber("begin number");
int finish = GetUserNumber("end number");
PrintNumbers(start, finish);
Console.WriteLine();

int GetUserNumber(string name)
{
  int number = 0;
  Console.Write($"Please enter {name}: ");
  number = int.Parse(Console.ReadLine()!);
  return number;
}

void PrintNumbers(int begin, int end)
{
  if (begin - 1 == end)
  {
    return;
  }
  PrintNumbers(begin, end - 1);
  Console.Write($"{end}  ");
}