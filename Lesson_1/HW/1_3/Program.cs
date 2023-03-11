// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine ("Write a number: ");

int n_1 = int.Parse(Console.ReadLine()!);

if (n_1 % 2 == 0)
{
  Console.Write($"The number {n_1} is even");
}
else
{
  Console.Write($"The number {n_1} is odd");
}