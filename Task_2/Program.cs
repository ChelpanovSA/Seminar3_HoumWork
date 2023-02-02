//* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве. A (3,6,8), B (2,1,-7) -> 15.84; A (7,-5, 0), B (1,-1,9) -> 11.53.*

Console.Clear();
Console.Write($"Введите координаты точки x1: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки y1: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки z1: ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки x2: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки y2: ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки z2: ");
int Z2 = int.Parse(Console.ReadLine()!);

double resX = Math.Pow(X2-X1, 2);
double resY = Math.Pow(Y2-Y1, 2);
double resZ = Math.Pow(Z2-Z1, 2);
double resouit = Math.Sqrt(resX + resY + resZ);

Console.WriteLine($"Растояние от точки A({X1},{Y1},{Z1}) до точки B({X2},{Y2}.{Z2}) равно: {resouit:F2}");