// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

// Получаем первую цифру, затем получаем вторую цифру. 
// первое число умножить на 10 + последнее.

Random random = new Random();
int number = random.Next(100,1000);
Console.WriteLine(number);

int firstNumber = number / 100;
int thirdNumber = number % 10;
int result = firstNumber * 10 + thirdNumber;

Console.WriteLine(result);