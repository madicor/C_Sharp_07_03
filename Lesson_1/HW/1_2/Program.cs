// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из них.

Console.WriteLine ("Enter the first number: ");
int n_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Enter the second number: ");
int n_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Enter the third number: ");
int n_3 = int.Parse(Console.ReadLine()!);

if (n_1 < n_2)
{
  n_1 = n_2;
}
if (n_1 < n_3)
{
  n_1 = n_3;
}
Console.Write($"The number {n_1} is the largest");