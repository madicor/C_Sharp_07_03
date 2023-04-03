// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.Write("Количество элементов в строке:");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Количество элементов в столбце:");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Начало диапазона:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Конец диапазона:");
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

int[,] MyFunc(int[,] arr)
{
  for (int i = 1; i < arr.GetLength(0); i += 2) 
  {
    for (int j = 1; j < arr.GetLength(1); j += 2)
    {
      arr[i, j]*=arr[i, j];
    }
  }
return arr;
}

PrintArray(MyFunc(array));