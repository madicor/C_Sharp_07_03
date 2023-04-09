// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int num = GetUserNumber("number");
int degree = GetUserNumber("power");
Console.WriteLine(ToThePower(num, degree));

int GetUserNumber(string name)
{
  int number = 0;
  Console.Write($"Please enter {name}: ");
  number = int.Parse(Console.ReadLine()!);
  return number;
}

int ToThePower(int number, int power)
{
  if (power == 1)
  {
    return number;
  }
  return ToThePower(number, power - 1) * number;
}