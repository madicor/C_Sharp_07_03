// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

void Quaters(int x, int y)
{
  if (x == 0 || y == 0)
      Console.WriteLine("x = 0, y == 0");
  else if (x > 0 && y > 0)
      Console.WriteLine("I");
  else if (x < 0 && y > 0)
      Console.WriteLine("II");
  else if (x < 0 && y < 0)
      Console.WriteLine("III");
  else if (x > 0 && y < 0)
      Console.WriteLine("IV");
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quaters(num_1, num_2);