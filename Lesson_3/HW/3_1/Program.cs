// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Please, enter a number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0] == number[4] || number[1] == number[3])
  {
    Console.WriteLine($"{number} - is a palindrome");
  }
  else Console.WriteLine($"{number} - is NOT a palindrome");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Error: {number} - is not five-digit");