// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12
// https://4apple.org/summa-diagonalnyh-jelementov-matricy/
// https://ru.wikipedia.org/wiki/%D0%93%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D0%B4%D0%B8%D0%B0%D0%B3%D0%BE%D0%BD%D0%B0%D0%BB%D1%8C

Console.Write("Кол-во элементов в строке:");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во элементов в столбце:");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапозона:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапозона:");
int b = int.Parse(Console.ReadLine()!);

int[,] MakeArray(int x, int y, int m, int n)
{
  int[,] array = new int[x, y];

  for (int i = 0; i < x; i++)
  {
    for (int j = 0; j < y; j++)
    {
      array[i, j] = new Random().Next(m, n + 1);
    }

  }

  return array;
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

int[,] array = MakeArray(x, y, a, b);
PrintArray(array);
////////////////////////////////////////////

int Sum(int[,] arr)
{
  int sum = 0;

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i==j) sum += arr[i, j];
    }
  }
  return sum;
}

Console.WriteLine(Sum(array));