// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

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
  if (end % 2 != 0)
  {
    end--;
  }

  if (end < begin)
  {
    return;
  }
  PrintNumbers(begin, end - 2);
  Console.Write($"{end}  ");
}