// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num = GetUserNumber();
int digits = SumNumbers(num);
Console.WriteLine(digits);

int GetUserNumber()
{
  int number = 0;
  while(number == 0)
  {
    Console.Write("Please, enter a number: ");
    number = int.Parse(Console.ReadLine()!);
  }
  return number;
}

int SumNumbers(int n)
{
  int sum = 0;
  for (int i = 1; i <= n; i++)
  {
    sum += n % 10;
    n /= 10;
  }
  return sum;
}