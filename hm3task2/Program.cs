// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты Х точки А");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки А");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z точки А");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Х точки B");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y точки B");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Z точки B");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

Console.WriteLine(Math.Round(distance, 2));
