// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine ("Enter the first number: ");
int n_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Enter the second number: ");
int n_2 = int.Parse(Console.ReadLine()!);

if (n_1 > n_2)
{
  Console.Write($"The number {n_1} is greater than {n_2}");
}
else if (n_1 == n_2)
{
  Console.Write("$The number {n_1} IServiceProvider equal to the number {n_2}");
}
else
{
  Console.Write($"The number {n_2} is greater than {n_1}");
}