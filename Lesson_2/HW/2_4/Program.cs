//  Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter a number from 1 to 7 ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) {
	if (Day >= 6) 
  {
		Console.Write("It's a day off");
	} 
  else 
  {
		Console.Write("It's a working day");
	}
} 
else 
{
	Console.Write("Enter a valid day between 1 and 7");
}