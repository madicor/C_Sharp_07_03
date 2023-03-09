// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("N = ");
int N = int.Parse(Console.ReadLine()!);

int count = -N;

while (count != N)
{
  Console.WriteLine(count);
  if (N < 0)
  {
    count--;
  }
  else
  {
    count++;
  }
}